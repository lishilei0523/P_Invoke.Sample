using System;
using System.Runtime.InteropServices;

namespace Sample.NativeLibrary.Declarations
{
    /// <summary>
    /// 消息包装
    /// </summary>
    public class MessageWrapper : IDisposable
    {
        #region # 字段及构造器

        /// <summary>
        /// 消息实例指针
        /// </summary>
        private readonly IntPtr _messagePtr;

        /// <summary>
        /// 创建消息构造器
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        public MessageWrapper(string title, string content)
        {
            this._messagePtr = CreateMessage(title, content);
        }

        #endregion

        #region # 属性

        #region 标题 —— string Title
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get
            {
                IntPtr textPtr = GetTitle(this._messagePtr);
                string text = Marshal.PtrToStringAnsi(textPtr);
                return text;
            }
            set => SetTitle(this._messagePtr, value);
        }
        #endregion

        #region 内容 —— string Content
        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get
            {
                IntPtr textPtr = GetContent(this._messagePtr);
                string text = Marshal.PtrToStringAnsi(textPtr);
                return text;
            }
            set => SetContent(this._messagePtr, value);
        }
        #endregion

        #endregion

        #region # 方法

        //Public

        #region 发送 —— void Send(string receiver)
        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="receiver">收件人</param>
        public void Send(string receiver)
        {
            Send(this._messagePtr, receiver);
        }
        #endregion

        #region 释放资源 —— void Dispose()
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            Dispose(this._messagePtr);
        }
        #endregion 


        //Declares

        #region # 创建消息 —— static extern IntPtr CreateMessage(string title, string content)
        /// <summary>
        /// 创建消息
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "createMessage")]
        private static extern IntPtr CreateMessage(string title, string content);
        #endregion

        #region # 发送消息 —— static extern void Send(IntPtr message, string receiver)
        /// <summary>
        /// 发送消息
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "send")]
        private static extern void Send(IntPtr message, string receiver);
        #endregion

        #region # 设置消息标题 —— static extern void SetTitle(IntPtr message, string title)
        /// <summary>
        /// 设置消息标题
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "setTitle")]
        private static extern void SetTitle(IntPtr message, string title);
        #endregion

        #region # 设置消息内容 —— static extern void SetContent(IntPtr message, string content)
        /// <summary>
        /// 设置消息内容
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "setContent")]
        private static extern void SetContent(IntPtr message, string content);
        #endregion

        #region # 获取消息标题 —— static extern IntPtr GetTitle(IntPtr message)
        /// <summary>
        /// 获取消息标题
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "getTitle")]
        private static extern IntPtr GetTitle(IntPtr message);
        #endregion

        #region # 获取消息内容 —— static extern IntPtr GetContent(IntPtr message)
        /// <summary>
        /// 获取消息内容
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "getContent")]
        private static extern IntPtr GetContent(IntPtr message);
        #endregion

        #region # 释放消息 —— static extern void Dispose(IntPtr message)
        /// <summary>
        /// 释放消息
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "dispose")]
        private static extern void Dispose(IntPtr message);
        #endregion

        #endregion
    }
}
