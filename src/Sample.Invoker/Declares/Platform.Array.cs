﻿using Sample.Invoker.Models;
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

        #region # 接收数组 —— static extern IntPtr ReceiveArray()
        /// <summary>
        /// 接收数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveArray")]
        public static extern IntPtr ReceiveArray();
        #endregion

        #region # 接收矩阵 —— static extern IntPtr ReceiveMatrix()
        /// <summary>
        /// 接收矩阵
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveMatrix")]
        public static extern IntPtr ReceiveMatrix();
        #endregion

        #region # 接收序列 —— static extern IntPtr ReceiveRange()
        /// <summary>
        /// 接收序列
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveRange")]
        public static extern IntPtr ReceiveRange();
        #endregion

        #region # 释放数组 —— static extern void DisposeArray(IntPtr pointer)
        /// <summary>
        /// 释放数组
        /// </summary>
        [DllImport(DllName, EntryPoint = "disposeArray")]
        public static extern void DisposeArray(IntPtr pointer);
        #endregion

        #region # 释放矩阵 —— static extern void DisposeMatrix(IntPtr pointer)
        /// <summary>
        /// 释放矩阵
        /// </summary>
        [DllImport(DllName, EntryPoint = "disposeMatrix")]
        public static extern void DisposeMatrix(IntPtr pointer);
        #endregion

        #region # 释放序列 —— static extern void DisposeRange(IntPtr pointer)
        /// <summary>
        /// 释放序列
        /// </summary>
        [DllImport(DllName, EntryPoint = "disposeRange")]
        public static extern void DisposeRange(IntPtr pointer);
        #endregion
    }
}
