using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperative_Race_Game.Asset.Script
{
    internal class ReleaseData
    {
        public string Version_Max { get; private set; }
        public string Version_Min { get; private set; }

        public ReleaseData(string latestVersion, string minimumVersion)
        {
            Version_Max = latestVersion;
            Version_Min = minimumVersion;
        }
    }
}
