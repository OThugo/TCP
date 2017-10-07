using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Client
{
    internal class ClientProgram
    {
        private static void Main(string[] args)
        {
            try
            {
                //使用TCP通道连接
                TcpClientChannel channel = new TcpClientChannel();
                ChannelServices.RegisterChannel(channel, true);
                //获得远程对象
                SimpleAssembly.HelloWorld helloworld =
                    (SimpleAssembly.HelloWorld)Activator.GetObject(
                    typeof(SimpleAssembly.HelloWorld),
                    "tcp://localhost:12345/HelloWorld");
                //调用远程对象方法
                helloworld.SayHi("A");
                helloworld.SayHi("B");
                helloworld.SayHi("C");               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}