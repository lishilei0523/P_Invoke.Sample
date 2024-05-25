using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RangeDesc
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
        public float[] Histogram;
    }
}
