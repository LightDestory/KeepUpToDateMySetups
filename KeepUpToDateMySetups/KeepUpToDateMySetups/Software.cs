using System;
namespace KeepUpToDateMySetups
{
    class Software
    {
        public String Name { get; }
        public String VersionUrl { get; }
        public String[] DownloadUrl { get; }
        public String HTMLPrefix { get; }
        public String HTMLSuffix { get; }
        public bool isSpecial { get; }

        public Software(String Name, String VersionUrl, String[] DownloadUrl, String HTMLPrefix, String HTMLSuffix, bool isSpecial)
        {
            this.Name = Name;
            this.VersionUrl = VersionUrl;
            this.DownloadUrl = DownloadUrl;
            this.HTMLPrefix = HTMLPrefix;
            this.HTMLSuffix = HTMLSuffix;
            this.isSpecial = isSpecial;
        }
    }
}
