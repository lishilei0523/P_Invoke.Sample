using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ArrayDesc
    {
        public IntPtr Numbers;
        public int Length;
    }
}
