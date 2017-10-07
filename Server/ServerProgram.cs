using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
    internal class ServerProgram
    {
        private static void Main(string[] args)
        {
            //利用TCP通道，并且侦听12345端口
            TcpServerChannel channel = new TcpServerChannel(12345);
            ChannelServices.RegisterChannel(channel, true);
            //使用WellKnown激活方式，并且使用SingleCall模式
            RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(SimpleAssembly.HelloWorld),
                    "HelloWorld",
                    WellKnownObjectMode.SingleCall);
            Console.Read();
        }
    }
}