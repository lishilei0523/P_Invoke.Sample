using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Sample.NativeLibrary.Declarations
{
    /// <summary>
    /// 平台声明 - 字符串
    /// </summary>
    public static partial class Platform
    {
        #region # 发送string —— static extern void SendString(string text)
        /// <summary>
        /// 发送string
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "sendString")]
        public static extern void SendString([MarshalAs(UnmanagedType.LPStr)] string text);
        #endregion

        #region # 发送StringBuilder —— static extern void SendStringBuilder(StringBuilder textBuilder)
        /// <summary>
        /// 发送StringBuilder
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "sendStringBuilder")]
        public static extern void SendStringBuilder(StringBuilder textBuilder);
        #endregion

        #region # 接收string —— static extern IntPtr ReceiveString()
        /// <summary>
        /// 接收string
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "receiveString")]
        public static extern IntPtr ReceiveString();
        #endregion
    }
}
