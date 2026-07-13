using System;
using System.Diagnostics;

namespace HzCheat.Memory
{
    public class MemoryAccessor
    {
        private Process process;
        private IntPtr processHandle;

        public bool AttachToProcess(string processName)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(processName);
                if (processes.Length > 0)
                {
                    process = processes[0];
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public byte[] ReadMemory(IntPtr address, int size)
        {
            byte[] buffer = new byte[size];
            // Чтение памяти
            return buffer;
        }
    }
}
