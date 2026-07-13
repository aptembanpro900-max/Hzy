using System;

namespace HzCheat.Memory
{
    public class MemoryReader
    {
        private MemoryAccessor accessor;

        public MemoryReader(MemoryAccessor memoryAccessor)
        {
            accessor = memoryAccessor;
        }

        public int ReadInt32(IntPtr address)
        {
            byte[] data = accessor.ReadMemory(address, sizeof(int));
            return BitConverter.ToInt32(data, 0);
        }

        public float ReadFloat(IntPtr address)
        {
            byte[] data = accessor.ReadMemory(address, sizeof(float));
            return BitConverter.ToSingle(data, 0);
        }
    }
}
