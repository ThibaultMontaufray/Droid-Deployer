// Log code : 00 - 10

using System;
using Tools4Libraries;

namespace Droid_deployer
{
    public static class Daemon
    {
        #region Attribute
        #endregion

        #region Properties
        public static bool Started
        {
            get
            {
                string row = ConsoleLauncher.ExecuteCommand("sy daemon status");
                return !row.Contains("syncanyd not running");
            }
        }
        public static int ProcessId
        {
            get
            {
                string row = ConsoleLauncher.ExecuteCommand("sy daemon status");
                if (row.Contains("syncanyd running"))
                {
                    try
                    {
                        return int.Parse(row.Split(' ')[row.Split(' ').Length - 1]);
                    }
                    catch (Exception exp)
                    {
                        Log.Write("[ ERR 0010 ] Error looking for the daemon PID : " + exp.Message);
                        return -2;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }
        #endregion

        #region Constructor
        #endregion

        #region Methods public
        public static void Start()
        {
            string row = ConsoleLauncher.ExecuteCommand("sy daemon start");
        }
        public static void Stop()
        {
            string row = ConsoleLauncher.ExecuteCommand("sy daemon stop");
        }
        #endregion
        
        #region Methods private
        #endregion
    }
}
