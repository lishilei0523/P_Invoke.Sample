namespace Sample.Invoker.Declarations
{
    /// <summary>
    /// 平台声明 - 常量
    /// </summary>
    public static partial class Platform
    {
        /// <summary>
        /// 程序集名称
        /// </summary>
#if NET20_OR_GREATER
        private const string DllName = "Sample.NativeLibrary.dll";
#endif
#if NETCOREAPP1_0_OR_GREATER
        private const string DllName = "Sample.NativeLibrary";
#endif
    }
}
