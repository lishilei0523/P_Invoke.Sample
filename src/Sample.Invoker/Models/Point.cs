using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Point
    {
        public Point(string name, int x, int y, string[] titles, float[] angles)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Titles = titles;
            this.Angles = angles;
        }

        public readonly string Name;

        public readonly int X;

        public readonly int Y;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public readonly string[] Titles;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public readonly float[] Angles;
    }
}
