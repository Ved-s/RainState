using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RainState
{
    public static class RainWorldData
    {
        static Regex SubregionNameRegex = new(@"Subregion: (.+)", RegexOptions.Compiled);

        public static string? RootDir { get; private set; }
        public static string? AssetsDir { get; private set; }

        public static Dictionary<string, Region>? Regions { get; private set; }
        public static Assembly? RWAssembly { get; private set; }

        public static string[]? LevelUnlocks { get; private set; }
        public static string[]? SandboxUnlocks { get; private set; }
        public static string[]? SafariUnlocks { get; private set; }
        public static string[]? SlugcatUnlocks { get; private set; }

        public static string[]? LorePearls { get; private set; }
        public static string[]? Broadcasts { get; private set; }

        public static string[]? AllSlugcats { get; private set; }
        public static string[]? PlayableSlugcats { get; private set; }

        public static void SetRainWorldPath(string? path)
        {
            if (path is null)
            {
                RootDir = null;
                AssetsDir = null;
                Regions = null;
                RWAssembly = null;

                LevelUnlocks = null;
                SandboxUnlocks = null;
                SafariUnlocks = null;
                SlugcatUnlocks = null;

                AllSlugcats = null;
                PlayableSlugcats = null;
                return;
            }

            RootDir = path;
            AssetsDir = Path.Combine(RootDir, "RainWorld_Data/StreamingAssets");
            if (!Directory.Exists(AssetsDir))
                AssetsDir = null;
            else
            {
                LoadRegions();
            }

            string assembly = Path.Combine(RootDir, "RainWorld_Data/Managed/Assembly-CSharp.dll");
            if (File.Exists(assembly))
            {
                RWAssembly = Assembly.LoadFrom(assembly);
                LoadAssemblyData();
            }

        }

        public static bool SearchRainWorld(string path)
        {
            SetRainWorldPath(null);

            string? rwpath = path;
            while (true)
            {
                if (rwpath is null)
                    break;

                if (File.Exists(Path.Combine(rwpath, "RainWorld.exe")))
                    break;

                rwpath = Path.GetDirectoryName(rwpath);
            }

            if (rwpath is null)
            {
                object? steampathobj =
                    Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam", "InstallPath", null) ??
                    Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam", "InstallPath", null);

                if (steampathobj is string steampath)
                {
                    rwpath = Path.Combine(steampath, "steamapps/common/Rain World");
                    if (!Directory.Exists(rwpath))
                        rwpath = null;
                }
            }

            if (rwpath is not null)
                SetRainWorldPath(rwpath);

            return rwpath is not null;
        }

        static void LoadRegions()
        {
            if (AssetsDir is null)
                return;

            List<string> worldpaths = new()
            {
                Path.Combine(AssetsDir, "world")
            };

            string mods = Path.Combine(AssetsDir, "mods");
            if (Directory.Exists(mods))
                foreach (string modpath in Directory.EnumerateDirectories(mods))
                    worldpaths.Add(Path.Combine(modpath, "world"));

            Dictionary<string, Region> regions = new();

            foreach (string worldpath in worldpaths)
            {
                if (!Directory.Exists(worldpath))
                    continue;

                foreach (string regionpath in Directory.EnumerateDirectories(worldpath))
                {
                    string id = Path.GetFileName(regionpath)!.ToUpper();
                    if (regions.ContainsKey(id))
                        continue;

                    string displaynamePath = Path.Combine(regionpath, "displayname.txt");
                    if (File.Exists(displaynamePath))
                    {
                        regions[id] = new(id, File.ReadAllText(displaynamePath));
                        continue;
                    }

                    string propertiesPath = Path.Combine(regionpath, "properties.txt");
                    if (File.Exists(propertiesPath))
                    {
                        string? name = null;
                        string properties = File.ReadAllText(propertiesPath);
                        Match subregion = SubregionNameRegex.Match(properties);
                        if (subregion.Success)
                            name = subregion.Groups[1].Value;
                        regions[id] = new(id, name);
                    }
                }
            }
            Regions = regions;
        }

        static void LoadAssemblyData()
        {
            if (RWAssembly is null)
                return;

            Dictionary<string, Action<IEnumerable<string>?>> extEnumHandlers = new()
            {
                ["LevelUnlockID"] = tokens => LevelUnlocks = tokens?.ToArray(),
                ["SandboxUnlockID"] = tokens => SandboxUnlocks = tokens?.ToArray(),
                ["SafariUnlockID"] = tokens => SafariUnlocks = tokens?.ToArray(),
                ["SlugcatUnlockID"] = tokens => SlugcatUnlocks = tokens?.ToArray(),
                ["DataPearlType"] = tokens => LorePearls = tokens?.ToArray(),
                ["ChatlogID"] = tokens => Broadcasts = tokens?.ToArray(),
                ["Name"] = tokens =>
                {
                    AllSlugcats = tokens?.ToArray();
                    PlayableSlugcats = tokens?.Where(t => t != "Night" && t != "Inv" && t != "Slugpup" && !t.StartsWith("JollyPlayer")).ToArray();
                }
            };

            Dictionary<string, HashSet<string>> extEnumValues = new();

            void ScanType(Type type)
            {
                foreach (FieldInfo field in type.GetFields(BindingFlags.Static | BindingFlags.Public))
                {
                    if (!extEnumHandlers.ContainsKey(field.FieldType.Name))
                        continue;

                    if (!extEnumValues.TryGetValue(field.FieldType.Name, out HashSet<string>? values))
                    {
                        values = new();
                        extEnumValues[field.FieldType.Name] = values;
                    }

                    FieldInfo? valueField = field.FieldType.GetField("value");
                    if (valueField is null || valueField.FieldType != typeof(string))
                        continue;

                    object? value = field.GetValue(null);

                    if (value is null)
                    {
                        MethodInfo? registerMethod = type.GetMethod("RegisterValues");
                        if (registerMethod is not null && registerMethod.IsStatic && registerMethod.GetParameters().Length == 0)
                        {
                            registerMethod.Invoke(null, null);
                            value = field.GetValue(null);
                        }
                    }

                    if (value is null)
                        continue;

                    values.Add((string)valueField.GetValue(value)!);
                }

                foreach (Type nested in type.GetNestedTypes())
                    ScanType(nested);
            }

            foreach (Type type in RWAssembly.GetExportedTypes())
                ScanType(type);

            foreach (var (type, handler) in extEnumHandlers)
            {
                if (extEnumValues.TryGetValue(type, out HashSet<string>? values))
                    handler(values);
                else
                    handler(null);
            }
        }

        public record Region(string Id, string? Name);
    }
}
