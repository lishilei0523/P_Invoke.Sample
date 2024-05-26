using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ArrayDesc
    {
        public ArrayDesc(IntPtr numbers, int length)
            : this()
        {
            this.Numbers = numbers;
            this.Length = length;
        }

        public readonly IntPtr Numbers;
        public readonly int Length;
    }
}
