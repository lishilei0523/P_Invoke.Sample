using System.Runtime.InteropServices;

namespace Sample.Invoker.Declarations
{
    /// <summary>
    /// 平台声明 - 异常
    /// </summary>
    public static partial class Platform
    {
        #region # 接收预期异常 —— static extern void ReceiveHandledExpcetion()
        /// <summary>
        /// 接收预期异常
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "receiveHandledExpcetion")]
        public static extern void ReceiveHandledExpcetion();
        #endregion

        #region # 接收未处理异常 —— static extern void ReceiveUnhandledExpcetion()
        /// <summary>
        /// 接收未处理异常
        /// </summary>
        [DllImport(Platform.DllName, EntryPoint = "receiveUnhandledExpcetion")]
        public static extern void ReceiveUnhandledExpcetion();
        #endregion
    }
}
