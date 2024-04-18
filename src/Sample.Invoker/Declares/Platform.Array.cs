using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Declares
{
    /// <summary>
    /// 平台声明 - 数组
    /// </summary>
    public static partial class Platform
    {
        #region # 发送整型数组 —— static extern void SendNumbers(int[] numbers, int length)
        /// <summary>
        /// 发送整型数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendNumbers")]
        public static extern void SendNumbers(int[] numbers, int length);
        #endregion

        #region # 接收整型数组 —— static extern IntPtr ReceiveNumbers()
        /// <summary>
        /// 接收整型数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveNumbers")]
        public static extern IntPtr ReceiveNumbers();
        #endregion

        #region # 发送字符串数组 —— static extern void SendStrings(string[] strings, int length)
        /// <summary>
        /// 发送字符串数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendStrings")]
        public static extern void SendStrings(string[] strings, int length);
        #endregion
    }
}
