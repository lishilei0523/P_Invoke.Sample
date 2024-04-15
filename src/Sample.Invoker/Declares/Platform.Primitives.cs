using System.Runtime.InteropServices;

namespace Sample.Invoker.Declares
{
    /// <summary>
    /// 平台声明 - 基元类型
    /// </summary>
    public static partial class Platform
    {
        //发送部分

        #region # 发送bool —— static extern void SendBool(bool enabled)
        /// <summary>
        /// 发送bool
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendBool")]
        public static extern void SendBool(bool enabled);
        #endregion

        #region # 发送byte —— static extern void SendByte(byte number)
        /// <summary>
        /// 发送byte
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendByte")]
        public static extern void SendByte(byte number);
        #endregion

        #region # 发送sbyte —— static extern void SendSByte(sbyte number)
        /// <summary>
        /// 发送sbyte
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendSByte")]
        public static extern void SendSByte(sbyte number);
        #endregion

        #region # 发送short —— static extern void SendShort(short number)
        /// <summary>
        /// 发送short
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendShort")]
        public static extern void SendShort(short number);
        #endregion

        #region # 发送ushort —— static extern void SendUShort(ushort number)
        /// <summary>
        /// 发送ushort
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendUShort")]
        public static extern void SendUShort(ushort number);
        #endregion

        #region # 发送int —— static extern void SendInt(int number)
        /// <summary>
        /// 发送int
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendInt")]
        public static extern void SendInt(int number);
        #endregion

        #region # 发送uint —— static extern void SendUInt(uint number)
        /// <summary>
        /// 发送uint
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendUInt")]
        public static extern void SendUInt(uint number);
        #endregion

        #region # 发送long —— static extern void SendLong(long number)
        /// <summary>
        /// 发送long
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendLong")]
        public static extern void SendLong(long number);
        #endregion

        #region # 发送ulong —— static extern void SendULong(ulong number)
        /// <summary>
        /// 发送ulong
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendULong")]
        public static extern void SendULong(ulong number);
        #endregion

        #region # 发送float —— static extern void SendFloat(float number)
        /// <summary>
        /// 发送float
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendFloat")]
        public static extern void SendFloat(float number);
        #endregion

        #region # 发送double —— static extern void SendDouble(double number)
        /// <summary>
        /// 发送double
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "sendDouble")]
        public static extern void SendDouble(double number);
        #endregion


        //接收部分

        #region # 接收bool —— static extern bool ReceiveBool()
        /// <summary>
        /// 接收bool
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveBool")]
        public static extern bool ReceiveBool();
        #endregion

        #region # 接收byte —— static extern byte ReceiveByte()
        /// <summary>
        /// 接收byte
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveByte")]
        public static extern byte ReceiveByte();
        #endregion

        #region # 接收sbyte —— static extern sbyte ReceiveSByte()
        /// <summary>
        /// 接收sbyte
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveSByte")]
        public static extern sbyte ReceiveSByte();
        #endregion

        #region # 接收short —— static extern short ReceiveShort()
        /// <summary>
        /// 接收short
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveShort")]
        public static extern short ReceiveShort();
        #endregion

        #region # 接收ushort —— static extern ushort ReceiveUShort()
        /// <summary>
        /// 接收ushort
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveUShort")]
        public static extern ushort ReceiveUShort();
        #endregion

        #region # 接收int —— static extern int ReceiveInt()
        /// <summary>
        /// 接收int
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveInt")]
        public static extern int ReceiveInt();
        #endregion

        #region # 接收uint —— static extern uint ReceiveUInt()
        /// <summary>
        /// 接收uint
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveUInt")]
        public static extern uint ReceiveUInt();
        #endregion

        #region # 接收long —— static extern long ReceiveLong()
        /// <summary>
        /// 接收long
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveLong")]
        public static extern long ReceiveLong();
        #endregion

        #region # 接收ulong —— static extern ulong ReceiveULong()
        /// <summary>
        /// 接收ulong
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveULong")]
        public static extern ulong ReceiveULong();
        #endregion

        #region # 接收float —— static extern float ReceiveFloat()
        /// <summary>
        /// 接收float
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveFloat")]
        public static extern float ReceiveFloat();
        #endregion

        #region # 接收double —— static extern double ReceiveDouble()
        /// <summary>
        /// 接收double
        /// </summary>
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "receiveDouble")]
        public static extern double ReceiveDouble();
        #endregion
    }
}
