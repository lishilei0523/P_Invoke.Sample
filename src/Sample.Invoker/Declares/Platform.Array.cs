using Sample.Invoker.Models;
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

        #region # 发送字符串数组 —— static extern void SendStrings(string[] strings, int length)
        /// <summary>
        /// 发送字符串数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendStrings")]
        public static extern void SendStrings(string[] strings, int length);
        #endregion

        #region # 发送结构体数组 —— static extern void SendPoints(Point[] points, int length)
        /// <summary>
        /// 发送结构体数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendPoints")]
        public static extern void SendPoints(Point[] points, int length);
        #endregion

        #region # 接收数组 —— static extern void ReceiveArray(IntPtr arrayDescPtr)
        /// <summary>
        /// 接收数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveArray")]
        public static extern void ReceiveArray(IntPtr arrayDescPtr);
        #endregion

        #region # 接收数组指针 —— static extern IntPtr ReceiveArrayPtr()
        /// <summary>
        /// 接收数组指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveArrayPtr")]
        public static extern IntPtr ReceiveArrayPtr();
        #endregion

        #region # 释放数组指针 —— static extern void DisposeArrayPtr(IntPtr arrayPtr)
        /// <summary>
        /// 释放数组指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "disposeArrayPtr")]
        public static extern void DisposeArrayPtr(IntPtr arrayPtr);
        #endregion
    }
}
