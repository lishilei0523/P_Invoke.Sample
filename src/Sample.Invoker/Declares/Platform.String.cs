using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Declares
{
    /// <summary>
    /// 平台声明 - 常量
    /// </summary>
    public static partial class Platform
    {
        #region # 发送string —— static extern void SendString(string text)
        /// <summary>
        /// 发送string
        /// </summary>
        [DllImport(DllName, CharSet = CharSet.Ansi, EntryPoint = "sendString")]
        public static extern void SendString([MarshalAs(UnmanagedType.LPStr)] string text);
        #endregion

        #region # 接收string —— static extern IntPtr ReceiveString()
        /// <summary>
        /// 接收string
        /// </summary>
        [DllImport(DllName, CharSet = CharSet.Ansi, EntryPoint = "receiveString")]
        public static extern IntPtr ReceiveString();
        #endregion

        #region # 接收STL string —— static extern IntPtr ReceiveStlString()
        /// <summary>
        /// 接收STL string
        /// </summary>
        [DllImport(DllName, CharSet = CharSet.Ansi, EntryPoint = "receiveStlString")]
        public static extern IntPtr ReceiveStlString();
        #endregion
    }
}
