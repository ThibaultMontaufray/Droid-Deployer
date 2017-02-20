// Log 00 01

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Tools4Libraries;

namespace Droid_deployer
{
    public static class SyncanyAdapter
    {
        #region Attribute
        #endregion

        #region PropertiesH
        public static List<Plugin> AvalailablePlugins
        {
            get
            {
                string[] tab = GetListPlugins();
                return Plugin.Parse(new List<string>(tab));
            }
        }
        public static string Status
        {
            get { return "";  }
        }
        #endregion

        #region Constructor
        static SyncanyAdapter()
        {
            Log.ApplicationAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Deployer";
        }
        #endregion

        #region Methods public
        public static void InstallFromScratch()
        {
            PluginInstall("sftp");
            Init();
        }

        /// <summary>
        /// Creates a new repository using any plugin and generates a syncany://link
        /// </summary>
		public static void Init()
        {
            ConsoleLauncher.ExecuteCommand("sy init");
        }
        /// <summary>
        /// connects to an existing repository using a syncany://-link
        /// </summary>
		public static void Connect(string repoName)
        {
            ConsoleLauncher.ExecuteCommand("sy connect syncanay://strorage/1/cby");
        }
        /// <summary>
        /// detects local changes and uploads them to the repository
        /// </summary>
        public static void Up()
        {
            ConsoleLauncher.ExecuteCommand("sy up");
        }
        /// <summary>
        /// downloads changes by other people and apply them to your local machine
        /// </summary>
        public static void Down()
        {
            ConsoleLauncher.ExecuteCommand("sy down");
        }
        /// <summary>
        /// starts background daemon to automatically sync your files
        /// </summary>
        public static void Starts()
        {
            ConsoleLauncher.ExecuteCommand("sy daemon start");
        }
        /// <summary>
        /// restores an old version of a file to the local folder
        /// </summary>
        public static void Restores(string revision)
        {
            ConsoleLauncher.ExecuteCommand("sy resetore --revision=2 5shr616");

        }
        /// <summary>
        /// downloads and install the plugin
        /// </summary>
        /// <param name="packcageName">Name of the plugin to install</param>
        public static void PluginInstall(string packcageName)
        {
            ConsoleLauncher.ExecuteCommand("sy plugin install " + packcageName);
        }
        #endregion

        #region Methods private
        private static string[] GetListPlugins()
        {
            string ret = ConsoleLauncher.ExecuteCommand("sy plugin list");
            return ret.Split('\n');
        }
        #endregion

        #region Event
        #endregion
    }
}
