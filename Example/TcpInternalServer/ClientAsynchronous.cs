﻿using System;
using System.Threading;

namespace AutoCSer.Example.TcpInternalServer
{
    /// <summary>
    /// 同步函数客户端异步测试 示例
    /// </summary>
    [AutoCSer.Net.TcpInternalServer.Server(Host = "127.0.0.1", Port = 12905)]
    partial class ClientAsynchronous
    {
        /// <summary>
        /// 同步函数客户端异步测试
        /// </summary>
        /// <param name="left">加法左值</param>
        /// <param name="right">加法右值</param>
        [AutoCSer.Net.TcpServer.Method(IsClientAsynchronous = true, IsClientSynchronous = true)]
        int Add(int left, int right)
        {
            return left + right;
        }

        /// <summary>
        /// 加法求和等待事件
        /// </summary>
        private static readonly EventWaitHandle sumWait = new EventWaitHandle(false, EventResetMode.AutoReset);
        /// <summary>
        /// 同步函数客户端异步测试
        /// </summary>
        /// <returns></returns>
        //[AutoCSer.Metadata.TestMethod]
        internal static bool TestCase()
        {
            using (AutoCSer.Example.TcpInternalServer.ClientAsynchronous.TcpInternalServer server = new AutoCSer.Example.TcpInternalServer.ClientAsynchronous.TcpInternalServer())
            {
                if (server.IsListen)
                {
                    using (AutoCSer.Example.TcpInternalServer.ClientAsynchronous.TcpInternalClient client = new AutoCSer.Example.TcpInternalServer.ClientAsynchronous.TcpInternalClient())
                    {
                        #region 同步代理调用
                        AutoCSer.Net.TcpServer.ReturnValue<int> sum = client.Add(2, 3);
                        if (sum.Type != Net.TcpServer.ReturnType.Success && sum.Value != 2 + 3)
                        {
                            return false;
                        }
                        #endregion

                        #region 异步代理调用
                        sum = default(AutoCSer.Net.TcpServer.ReturnValue<int>);
                        sumWait.Reset();
                        client.Add(2, 3, value =>
                        {
                            sum = value;
                            sumWait.Set();
                        });
                        sumWait.WaitOne();
                        if (sum.Type != Net.TcpServer.ReturnType.Success && sum.Value != 2 + 3)
                        {
                            return false;
                        }
                        #endregion

                        return true;
                    }
                }
            }
            return false;
        }
    }
}
