﻿using System;
using System.Diagnostics;
using AutoCSer.Extension;
using System.Threading;

namespace AutoCSer.TestCase.TcpInternalClientPerformance
{
    static unsafe class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"http://www.AutoCSer.com/TcpServer/MethodServer.html
");
            Client.Start("AutoCSer.TestCase.TcpInternalClientPerformance", test);
        }
        /// <summary>
        /// 测试
        /// </summary>
        private static void test()
        {
            Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpServerPerformance.Add>> onAdd = Client.OnAdd;
            Action<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.TestCase.TcpInternalServerPerformance.ServerCustomSerialize>> onCustomSerialize = Client.OnAdd;
            int left = Client.Left;
            using (AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer.TcpInternalClient client = new AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer.TcpInternalClient())
            {
                tcpClient = client._TcpClient_;
                Client.SendCount = Client.ReceiveCount = 0;

                if (Client.IsCreatedProcessWait)
                {
                    Client.Start(TestType.CustomSerialize, Client.Count);
                    using (AutoCSer.Net.TcpServer.KeepCallback customSerializeKeep = client.addCustomSerialize(onCustomSerialize))
                    {
                        new AutoCSer.TestCase.TcpInternalServerPerformance.ClientCustomSerializeOutput(left, Client.Count, client.addCustomSerialize).Wait();
                        client.addCustomSerializeFinally();
                        Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                        wait();
                    }
                    sleep();

                    Client.Start(TestType.ClientCustomSerialize, Client.Count);
                    using (AutoCSer.Net.TcpServer.KeepCallback sendKeep = client.addRegister(onAdd))
                    {
                        new AutoCSer.TestCase.TcpInternalServerPerformance.ClientCustomSerializeOutput(left, Client.Count, client.addCustomSerializeRegister).Wait();
                        Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                        wait();
                        sleep();

                        Client.Start(TestType.Register, Client.Count);
                        for (int right = Client.Count; right != 0; client.addRegister(left, --right)) ;
                        Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                        wait();
                    }
                    sleep();
                }

                Client.Start(TestType.Asynchronous, Client.Count);
                for (int right = Client.Count; right != 0; client.addAsynchronous(left, --right, onAdd)) ;
                Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

                Client.Start(TestType.Synchronous, Client.Count);
                for (int right = Client.Count; right != 0; client.addSynchronous(left, --right, onAdd)) ;
                Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

                Client.Start(TestType.Queue, Client.Count);
                for (int right = Client.Count; right != 0; client.addQueue(left, --right, onAdd)) ;
                Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

                Client.Start(TestType.Timeout, Client.Count);
                for (int right = Client.Count; right != 0; client.addTimeoutTask(left, --right, onAdd)) ;
                Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

                Client.Start(TestType.TcpTask, Client.Count);
                for (int right = Client.Count; right != 0; client.addTcpTask(left, --right, onAdd)) ;
                Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

                //服务端应尽量统一线程模式，混合测试会因为线程切换问题大幅降低测试吞吐性能
                Client.Start(TestType.Mixing, Client.Count);
                for (int right = Client.Count; right != 0;)
                {
                    client.addAsynchronous(left, --right, onAdd);
                    client.addSynchronous(left, --right, onAdd);
                    client.addQueue(left, --right, onAdd);
                    client.addTcpTask(left, --right, onAdd);
                    client.addTimeoutTask(left, --right, onAdd);
                }
                Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

#if DOTNET2
                //.NET 2.0 线程池调度太烂，任务数量 / 10
                Client.Start(TestType.ThreadPool, Client.Count / 10);
                for (int right = Client.Count / 10; right != 0; client.addThreadPool(left, --right, onAdd)) ;
#else
                Client.Start(TestType.ThreadPool, Client.Count);
                for (int right = Client.Count; right != 0; client.addThreadPool(left, --right, onAdd)) ;
#endif
                Console.WriteLine("loop end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                GC.Collect();
                sleep();

                //该框架是为高吞吐的内部服务设计的，所以性能设计上对于客户端异步模式友好，而不利于客户端同步应答模式。
                //当然这种设计主要影响的客户端性能，可能需要多个客户端（多台客户机）同时采用多线程并发模式才能测试出服务端的吞吐性能上限。
                //客户端多线程同步应答模式会造成客户端线程切换问题大幅降低测试吞吐性能，同时会影响服务端批量处理数据的上限。
                int threadCount = 64;
                Client.ThreadCount = threadCount;
                Client.Start(TestType.ClientSynchronous, Client.Count / 10);
                for (int count = threadCount, right = Client.Count / 10 / threadCount; count != 0; --count)
                {
                    AutoCSer.Threading.ThreadPool.TinyBackground.Start(new ClientSynchronous { Client = client, Left = left, Right = right }.Run);
                }
                Console.WriteLine("thread start " + threadCount.toString() + " end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

                //客户端单线程同步应答模式，会完全退化为普通的应答请求
                Client.Start(TestType.ClientSynchronous, Client.Count / 100);
                for (int right = Client.Count / 100; right != 0;)
                {
                    if (client.add(left, --right).Value != left + right) ++Client.ErrorCount;
                }
                Client.Time.Stop();
                Client.WaitHandle.Set();
                Console.WriteLine("thread 1");
                wait();
                sleep();
                                
#if DOTNET2
#else
#if DOTNET4
#else
                //并发线程较多的时候测试吞吐性能可能高于单纯的同步模式
                Client.ThreadCount = threadCount = 256;
                Client.Start(TestType.ClientTaskAsync, Client.Count / 10);
                for (int count = threadCount, right = Client.Count / 10 / threadCount; count != 0; --count)
                {
                    System.Threading.Tasks.Task.Run(new ClientTaskAsync { Client = client, Left = left, Right = right }.Run);
                }
                Console.WriteLine("task start " + threadCount.toString() + " end " + Client.Time.ElapsedMilliseconds.toString() + "ms");
                wait();
                sleep();

                Client.ThreadCount = 1;
                Client.Start(TestType.ClientTaskAsync, Client.Count / 100);
                new ClientTaskAsync { Client = client, Left = left, Right = Client.Count / 100 }.Run().Wait();
                Console.WriteLine("task 1");
                wait();
                sleep();

                //在同步上下文环境中的测试吞吐不如普通的同步应答模式
                Client.Start(TestType.ClientTaskAsync, Client.Count / 100);
                for (int right = Client.Count / 100; right != 0;)
                {
                    if (client.addAsync(left, --right).Result.Value != left + right) ++Client.ErrorCount;
                }
                Client.Time.Stop();
                Client.WaitHandle.Set();
                Console.WriteLine("task Result");
                wait();
                sleep();
#endif
#endif
            }
        }
        /// <summary>
        /// TCP 内部服务客户端
        /// </summary>
        private static AutoCSer.Net.TcpInternalServer.Client<AutoCSer.TestCase.TcpInternalServerPerformance.InternalServer.TcpInternalClient> tcpClient;
        /// <summary>
        /// 等待测试结束
        /// </summary>
        private static void wait()
        {
            Client.WaitHandle.WaitOne();
            long milliseconds = Math.Max(Client.Time.ElapsedMilliseconds, 1);
            Console.WriteLine(Client.LoopCount.toString() + " / " + milliseconds.toString() + " = " + (Client.LoopCount / milliseconds) + "/ms send[" + Client.GetSendCount(tcpClient.SendCount).toString() + "] receive[" + Client.GetReceiveCount(tcpClient.ReceiveCount).toString() + "]" + (Client.ErrorCount == 0 ? null : (" ERROR[" + Client.ErrorCount.toString() + "]")) + " " + Client.TestType.ToString());
        }
        /// <summary>
        /// 休息 3 秒
        /// </summary>
        private static void sleep()
        {
            Console.WriteLine(@"Sleep 3000ms
");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
