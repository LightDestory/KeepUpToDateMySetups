namespace KeepUpToDateMySetups
{
    static class SetupsContainer
    {
        private static Software[] Available =
        {
            new Software("Revo Uninstaller Freeware", "https://www.revouninstaller.com/revo_uninstaller_free_download.html", new string[] { "https://www.revouninstaller.com/download-freeware-version.php" }, "<a href=\"revo_uninstaller_full_version_history.html\">Version: <span class=\"version\">", "</span></a>", false),
            new Software("Revo Uninstaller Pro", "https://www.revouninstaller.com/revo_uninstaller_free_download.html", new string[] { "https://www.revouninstaller.com/download-professional-version.php" }, "<a href=\"revo_uninstaller_pro_full_version_history.html\">Version: <span class=\"version\">", "</span></a>", false)
        };

        public static Software[] GetCollection()
        {
            return Available;
        }

        public static Software GetSoftwareByName(string Name)
        {
            Software search = null;
            foreach(Software s in Available)
            {
                if (s.Name.Equals(Name))
                {
                    search = s;
                    break;
                }
            }
            return search;
        }
    }
}
