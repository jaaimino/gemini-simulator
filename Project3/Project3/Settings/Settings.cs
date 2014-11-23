using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public static class Settings
    {
        private static PropertiesFile settingsFile;
        public static String[] cacheOptions = { "Direct Mapped", "Two-Way Set Associative" };

        public static void initialize()
        {
            Settings.settingsFile = new PropertiesFile("settings.properties");
            if (!settingsFile.containsKey("cachetype"))
            {
                settingsFile.set("cachetype", 0);
            }
            if (!settingsFile.containsKey("cachesize"))
            {
                settingsFile.set("cachesize", 10);
            }
            if (!settingsFile.containsKey("branchpredict"))
            {
                settingsFile.set("branchpredict", false);
            }
            if (!settingsFile.containsKey("bypassing"))
            {
                settingsFile.set("bypassing", false);
            }
            settingsFile.Save();
        }

        public static String getValue(String key)
        {
            return settingsFile.get(key);
        }

        public static void setValue(String key, Object value)
        {
            settingsFile.set(key, value);
        }

        public static void save()
        {
            settingsFile.Save();
        }

    }
}
