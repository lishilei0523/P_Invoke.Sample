using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct MatrixDesc
    {
        public MatrixDesc(IntPtr matrix, int rows, int cols)
            : this()
        {
            this.Matrix = matrix;
            this.Rows = rows;
            this.Cols = cols;
        }

        public readonly IntPtr Matrix;
        public readonly int Rows;
        public readonly int Cols;
    }
}
