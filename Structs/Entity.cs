using System;

namespace HzCheat.Structs
{
    public class Entity
    {
        public IntPtr Address { get; set; }
        public Vector3 Position { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }

        public Entity(IntPtr address)
        {
            Address = address;
        }
    }
}
