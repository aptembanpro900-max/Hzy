using System;
using System.Diagnostics;

namespace HzCheat.Process
{
    public class ProcessHelper
    {
        public static Process FindProcess(string processName)
        {
            try
            {
                Process[] processes = System.Diagnostics.Process.GetProcessesByName(processName);
                return processes.Length > 0 ? processes[0] : null;
            }
            catch
            {
                return null;
            }
        }

        public static bool IsProcessRunning(string processName)
        {
            return FindProcess(processName) != null;
        }
    }
}
