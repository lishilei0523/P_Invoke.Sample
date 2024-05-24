using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MatrixDesc
    {
        public IntPtr Matrix;
        public int Rows;
        public int Cols;
    }
}
