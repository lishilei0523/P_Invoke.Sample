using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4x4
    {
        public const int RowsCount = 4;
        public const int ColsCount = 4;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public float[] Matrix;
    }
}
