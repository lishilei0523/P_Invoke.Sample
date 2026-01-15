using System;
using System.Runtime.InteropServices;

namespace Sample.NativeLibrary.Declarations
{
    /// <summary>
    /// 消息包装
    /// </summary>
    public class MessageWrapper : IDisposable
    {
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


        private readonly IntPtr _messagePtr;

        public MessageWrapper(string title, string content)
        {
            this._messagePtr = CreateMessage(title, content);
        }

        public string Title
        {
            get
            {
                IntPtr textPtr = GetTitle(this._messagePtr);
                string text = Marshal.PtrToStringAnsi(textPtr);
                return text;
            }
        }

        public string Content
        {
            get
            {
                IntPtr textPtr = GetContent(this._messagePtr);
                string text = Marshal.PtrToStringAnsi(textPtr);
                return text;
            }
        }

        public void Send(string receiver)
        {
            Send(this._messagePtr, receiver);
        }

        public void Dispose()
        {
            Dispose(this._messagePtr);
        }
    }
}
