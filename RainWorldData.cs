using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RainState
{
    public static class RainWorldData
    {
        static Regex SubregionNameRegex = new(@"Subregion: (.+)", RegexOptions.Compiled);

        public static string? RootDir { get; private set; }
        public static string? RegionsDir { get; private set; }

        public static Region[]? Regions { get; private set; }
        public static Assembly? RWAssembly { get; private set; }

        public static string?[]? LevelUnlocks { get; private set; }
        public static string?[]? SandboxUnlocks { get; private set; }

        public static void SetRainWorldPath(string? path)
        {
            if (path is null)
            {
                RootDir = null;
                RegionsDir = null;
                Regions = null;
                RWAssembly = null;
                SandboxUnlocks = null;
                LevelUnlocks = null;
                return;
            }

            RootDir = path;
            RegionsDir = Path.Combine(path, "World/Regions");

            if (!Directory.Exists(RegionsDir))
                RegionsDir = null;
            else
                LoadRegions();

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
                    return false;

                if (File.Exists(Path.Combine(rwpath, "RainWorld.exe")))
                    break;

                rwpath = Path.GetDirectoryName(rwpath);
            }

            SetRainWorldPath(rwpath);
            return true;
        }

        static void LoadRegions()
        {
            if (RegionsDir is null)
                return;

            string infopath = Path.Combine(RegionsDir, "regions.txt");
            if (!File.Exists(infopath))
                return;

            string[] regionIds = File.ReadAllLines(infopath);
            Region[] regions = new Region[regionIds.Length];

            for (int i = 0; i < regionIds.Length; i++)
            {
                string id = regionIds[i];
                string propertiesPath = Path.Combine(RegionsDir, id, "Properties.txt");
                string? name = null;
                if (File.Exists(propertiesPath))
                {
                    string properties = File.ReadAllText(propertiesPath);
                    Match subregion = SubregionNameRegex.Match(properties);
                    if (subregion.Success)
                        name = subregion.Groups[1].Value;
                }
                regions[i] = new(id, name);
            }
            Regions = regions;
        }

        static void LoadAssemblyData()
        {
            if (RWAssembly is null)
                return;

            string?[]? LoadEnum(Type? type)
            {
                if (type is null)
                    return null;

                Dictionary<int, string> values = new();
                int maxId = -1;
                foreach (FieldInfo field in type.GetFields(BindingFlags.Static | BindingFlags.Public))
                {
                    int id = (int)field.GetValue(null)!;
                    values[id] = field.Name;
                    maxId = Math.Max(maxId, id);
                }

                string?[] valueArray = new string?[maxId + 1];
                foreach (var (id, value) in values)
                    valueArray[id] = value;

                return valueArray;
            }

            Type? multiplayerUnlocks = RWAssembly.GetType("MultiplayerUnlocks");
            if (multiplayerUnlocks is not null)
            {
                SandboxUnlocks = LoadEnum(multiplayerUnlocks.GetNestedType("SandboxUnlockID"));
                LevelUnlocks = LoadEnum(multiplayerUnlocks.GetNestedType("LevelUnlockID"));
            }
        }

        public record struct Region(string Id, string? Name);
    }
}
