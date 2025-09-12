using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperative_Race_Game.Asset.Script
{
    internal class GetPath
    {
        public static string getPath()
        {
            // 実行ファイルのあるフォルダ（bin/Debug/netX.Y/）
            string baseDir = AppContext.BaseDirectory;

            // プロジェクト直下へ戻る（bin/Debug/netX.Y/ から ../../ ）
            string projectDir = Path.GetFullPath(Path.Combine(baseDir, @"..\..\.."));


            return projectDir;
        }
    }
}
