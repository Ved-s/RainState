using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RainState
{
    public static class RainWorldData
    {
        static string[] RegionDefPaths = new[] { "world/regions.txt", "mergedmods/world/regions.txt" };
        static Regex SubregionNameRegex = new(@"Subregion: (.+)", RegexOptions.Compiled);

        public static string? RootDir { get; private set; }
        public static string? AssetsDir { get; private set; }

        public static Dictionary<string, Region>? Regions { get; private set; }
        public static Assembly? RWAssembly { get; private set; }

        public static string[]? LevelUnlocks { get; private set; }
        public static string[]? SandboxUnlocks { get; private set; }



        public static void SetRainWorldPath(string? path)
        {
            if (path is null)
            {
                RootDir = null;
                AssetsDir = null;
                Regions = null;
                RWAssembly = null;
                SandboxUnlocks = null;
                LevelUnlocks = null;
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

            Dictionary<string, Region> regions = new ();

            foreach (string regdefpath in RegionDefPaths)
            {
                string infopath = Path.Combine(AssetsDir, regdefpath);
                if (!File.Exists(infopath))
                    return;

                string regionsDir = Path.GetDirectoryName(infopath)!;
                string[] regionIds = File.ReadAllLines(infopath);

                foreach (string id in regionIds)
                {
                    string propertiesPath = Path.Combine(regionsDir, id, "properties.txt");
                    string? name = null;
                    if (File.Exists(propertiesPath))
                    {
                        string properties = File.ReadAllText(propertiesPath);
                        Match subregion = SubregionNameRegex.Match(properties);
                        if (subregion.Success)
                            name = subregion.Groups[1].Value;
                    }
                    regions[id] = new(id, name);
                }
            }
            Regions = regions;
        }

        static void LoadAssemblyData()
        {
            if (RWAssembly is null)
                return;

            string[]? LoadUnlocks(Type? type)
            {
                if (type is null)
                    return null;

                FieldInfo? valueField = type.GetField("value");
                if (valueField is null || valueField.FieldType != typeof(string))
                    return null;

                List<string> values = new();
                foreach (FieldInfo field in type.GetFields(BindingFlags.Static | BindingFlags.Public))
                {
                    if (field.FieldType != type)
                        continue;

                    object? unlocks = field.GetValue(null);
                    values.Add((string)valueField.GetValue(unlocks)!);
                }

                return values.ToArray();
            }

            Type? multiplayerUnlocks = RWAssembly.GetType("MultiplayerUnlocks");
            if (multiplayerUnlocks is not null)
            {
                SandboxUnlocks = LoadUnlocks(multiplayerUnlocks.GetNestedType("SandboxUnlockID"));
                LevelUnlocks = LoadUnlocks(multiplayerUnlocks.GetNestedType("LevelUnlockID"));
            }
        }

        public record Region(string Id, string? Name);
    }
}
