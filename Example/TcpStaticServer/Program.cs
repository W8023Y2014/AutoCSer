﻿using System;
using System.Threading;

namespace AutoCSer.Example.TcpStaticServer
{
    class Program
    {
        //[AutoCSer.Metadata.TestMethod]
        static void Main(string[] args)
        {
            bool createdProcessWait;
            EventWaitHandle processWait = new EventWaitHandle(false, EventResetMode.ManualReset, "AutoCSer.Example.TcpStaticServer", out createdProcessWait);
            if (createdProcessWait)
            {
                using (processWait)
                {
                    using (AutoCSer.Example.TcpStaticServer.TcpStaticServer.Example1 server1 = new AutoCSer.Example.TcpStaticServer.TcpStaticServer.Example1())
                    using (AutoCSer.Example.TcpStaticServer.TcpStaticServer.Example2 server2 = new AutoCSer.Example.TcpStaticServer.TcpStaticServer.Example2())
                    {
                        Console.WriteLine(@"http://www.AutoCSer.com/TcpServer/MethodServer.html
");
                        if (server1.IsListen && server2.IsListen)
                        {
                            Console.WriteLine(NoAttribute.TestCase());
                            Console.WriteLine(Static.TestCase());
                            Console.WriteLine(Field.TestCase());
                            Console.WriteLine(Property.TestCase());
                            Console.WriteLine(RefOut.TestCase());
                            Console.WriteLine(ClientAsynchronous.TestCase());
                            Console.WriteLine(SendOnly.TestCase());
                            Console.WriteLine(Asynchronous.TestCase());
                            Console.WriteLine(KeepCallback.TestCase());
                            Console.WriteLine("Over");
                        }
                        else Console.WriteLine("示例服务启动失败");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
