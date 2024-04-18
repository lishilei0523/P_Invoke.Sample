using Sample.Invoker.Models;
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
    }
}
