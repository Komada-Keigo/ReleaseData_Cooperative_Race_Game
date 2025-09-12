using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cooperative_Race_Game.Asset.Script
{
    internal class Update_ReleaseData
    {
        public static void Update()
        {
            ReleaseData forDebug = new ReleaseData(latestVersion: "0.1.0", minimumVersion: "0.1.0");
            ReleaseData forIOS = new ReleaseData(latestVersion: "0.1.0", minimumVersion: "0.1.0");
            ReleaseData forAndroid = new ReleaseData(latestVersion: "0.1.0", minimumVersion: "0.1.0");

            updatePublicData("ReleaseData_Debug", forDebug);
            updatePublicData("ReleaseData_IOS", forIOS);
            updatePublicData("ReleaseData_Android", forAndroid);
        }

        static void updatePublicData(string target, ReleaseData data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(data, options);

            Console.WriteLine($"WriteFile : {target}, {jsonString.Length}");

            // ファイルに書き込み
            Write(target, jsonString);
        }

        public static void Write(string target, string content)
        {
            string path = Path.Join(GetPath.getPath(), "docs", $"{target}.json");
            
            Console.WriteLine($"WriteFile : {path}, {content}");

            // ファイルに書き込み
            File.WriteAllText(path, content);
        }
    }
}
