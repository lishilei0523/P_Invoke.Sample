﻿using System.Runtime.InteropServices;

namespace Sample.Invoker.Declares
{
    /// <summary>
    /// 平台声明
    /// </summary>
    public static class Platform
    {
        /// <summary>
        /// 程序集名称
        /// </summary>
        private const string DllName = "Sample.NativeLibrary.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "greet")]
        public static extern int Greet([MarshalAs(UnmanagedType.LPStr)] string text);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sum")]
        public static extern int Sum(int a, int b);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "minus")]
        public static extern int Minus(int a, int b);
    }
}
