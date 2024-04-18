using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public Point() { }

        public Point(string name, int x, int y)
            : this()
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public string Name;

        public int X;

        public int Y;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] Angles;
    }
}
