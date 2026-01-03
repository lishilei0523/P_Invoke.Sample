using System.Runtime.InteropServices;

namespace Sample.NativeLibrary.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct RangeDesc
    {
        public RangeDesc(float[] histogram)
            : this()
        {
            this.Histogram = histogram;
        }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
        public readonly float[] Histogram;
    }
}
