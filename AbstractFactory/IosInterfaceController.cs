using System;

namespace AbstractFactory
{
    public class IosInterfaceController : IInterface
    {
        public void Play()
        {
            Console.WriteLine("Ios 游戏界面控制");
        }
    }
}
