using System;

namespace FactoryMethod
{
    public class Bmw : ICar
    {
        public void Run()
        {
            Console.WriteLine("宝马车启动了");
        }
    }
}
