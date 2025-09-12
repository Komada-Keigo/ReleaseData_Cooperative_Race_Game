using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperative_Race_Game.Asset.Script
{
    internal class ReleaseData
    {
        public string LatestVersion { get; private set; }
        public string MinimumVersion { get; private set; }

        public ReleaseData(string latestVersion, string minimumVersion)
        {
            LatestVersion = latestVersion;
            MinimumVersion = minimumVersion;
        }
    }
}
