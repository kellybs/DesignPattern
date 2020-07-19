using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AndroidInterfaceController : IInterface
    {
        public void Play()
        {
            Console.WriteLine("android 游戏界面控制");
        }
    }
}
