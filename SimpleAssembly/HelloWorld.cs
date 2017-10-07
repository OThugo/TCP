using System;

namespace SimpleAssembly
{
    public class HelloWorld : MarshalByRefObject
    {
        public HelloWorld()
            : base()
        {
            Console.WriteLine("对象被创建！");
        }

        ~HelloWorld()
        {
            Console.WriteLine("对象被析构！");
        }

        public void SayHi(String name)
        {
            Console.WriteLine("你好，{0}！", name);
        }
    }
}