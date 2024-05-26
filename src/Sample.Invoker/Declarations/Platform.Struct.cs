using Sample.Invoker.Models;
using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker.Declarations
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
        [DllImport(Platform.DllName, EntryPoint = "sendPoint")]
        public static extern void SendPoint(Point point);
        #endregion

        #region # 发送结构体引用 —— static extern void SendPointRef(ref Point point)
        /// <summary>
        /// 发送结构体引用
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "sendPointRef")]
        public static extern void SendPointRef(ref Point point);
        #endregion

        #region # 发送结构体指针 —— static extern void SendPointPtr(IntPtr pointPtr)
        /// <summary>
        /// 发送结构体指针
        /// </summary>
        /// <remarks>不建议使用</remarks>
        [DllImport(Platform.DllName, EntryPoint = "sendPointPtr")]
        public static extern void SendPointPtr(IntPtr pointPtr);
        #endregion

        #region # 发送嵌套结构体 —— static extern void SendRectangle(Rectangle rectangle)
        /// <summary>
        /// 发送嵌套结构体
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "sendRectangle")]
        public static extern void SendRectangle(Rectangle rectangle);
        #endregion

        #region # 发送嵌套结构体引用 —— static extern void SendRectangleRef(ref Rectangle rectangle)
        /// <summary>
        /// 发送嵌套结构体引用
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "sendRectangleRef")]
        public static extern void SendRectangleRef(ref Rectangle rectangle);
        #endregion

        #region # 发送嵌套结构体指针 —— static extern void SendRectanglePtr(IntPtr rectanglePtr)
        /// <summary>
        /// 发送嵌套结构体指针
        /// </summary>
        /// <remarks>不建议使用</remarks>
        [DllImport(Platform.DllName, EntryPoint = "sendRectanglePtr")]
        public static extern void SendRectanglePtr(IntPtr rectanglePtr);
        #endregion

        #region # 接收结构体 —— static extern IntPtr ReceivePoint()
        /// <summary>
        /// 接收结构体
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "receivePoint")]
        public static extern IntPtr ReceivePoint();
        #endregion

        #region # 接收嵌套结构体 —— static extern IntPtr ReceiveRectangle()
        /// <summary>
        /// 接收嵌套结构体
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "receiveRectangle")]
        public static extern IntPtr ReceiveRectangle();
        #endregion

        #region # 释放结构体 —— static extern void DisposePoint(IntPtr pointer)
        /// <summary>
        /// 释放结构体
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "disposePoint")]
        public static extern void DisposePoint(IntPtr pointer);
        #endregion

        #region # 释放嵌套结构体 —— static extern void DisposeRectangle(IntPtr pointer)
        /// <summary>
        /// 释放嵌套结构体
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "disposeRectangle")]
        public static extern void DisposeRectangle(IntPtr pointer);
        #endregion
    }
}
