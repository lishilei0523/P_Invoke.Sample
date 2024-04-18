using Sample.Invoker.Models;
using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Declares
{
    /// <summary>
    /// 平台声明 - 结构体
    /// </summary>
    public static partial class Platform
    {
        #region # 发送结构体 —— static extern void SendPoint(Point point)
        /// <summary>
        /// 发送结构体
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendPoint")]
        public static extern void SendPoint(Point point);
        #endregion

        #region # 发送嵌套结构体 —— static extern void SendRectangle(Rectangle rectangle)
        /// <summary>
        /// 发送嵌套结构体
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendRectangle")]
        public static extern void SendRectangle(Rectangle rectangle);
        #endregion

        #region # 发送结构体指针 —— static extern void SendPointPtr(IntPtr pointPtr)
        /// <summary>
        /// 发送结构体指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendPointPtr")]
        public static extern void SendPointPtr(IntPtr pointPtr);
        #endregion

        #region # 发送嵌套结构体指针 —— static extern void SendRectanglePtr(IntPtr pointPtr)
        /// <summary>
        /// 发送嵌套结构体指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "sendRectanglePtr")]
        public static extern void SendRectanglePtr(IntPtr pointPtr);
        #endregion

        #region # 接收结构体 —— static extern void ReceivePoint(IntPtr pointPtr)
        /// <summary>
        /// 接收结构体
        /// </summary>
        [DllImport(DllName, EntryPoint = "receivePoint")]
        public static extern void ReceivePoint(IntPtr pointPtr);
        #endregion

        #region # 接收嵌套结构体 —— static extern void ReceiveRectangle(IntPtr rectanglePtr)
        /// <summary>
        /// 接收嵌套结构体
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveRectangle")]
        public static extern void ReceiveRectangle(IntPtr rectanglePtr);
        #endregion

        #region # 接收结构体指针 —— static extern IntPtr ReceivePointPtr()
        /// <summary>
        /// 接收结构体指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "receivePointPtr")]
        public static extern IntPtr ReceivePointPtr();
        #endregion

        #region # 接收嵌套结构体指针 —— static extern IntPtr ReceiveRectanglePtr()
        /// <summary>
        /// 接收嵌套结构体指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "receiveRectanglePtr")]
        public static extern IntPtr ReceiveRectanglePtr();
        #endregion

        #region # 释放结构体指针 —— static extern void DisposePointPtr(IntPtr pointPtr)
        /// <summary>
        /// 释放结构体指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "disposePointPtr")]
        public static extern void DisposePointPtr(IntPtr pointPtr);
        #endregion

        #region # 释放嵌套结构体指针 —— static extern void DisposeRectanglePtr(IntPtr pointPtr)
        /// <summary>
        /// 释放嵌套结构体指针
        /// </summary>
        [DllImport(DllName, EntryPoint = "disposeRectanglePtr")]
        public static extern void DisposeRectanglePtr(IntPtr pointPtr);
        #endregion
    }
}
