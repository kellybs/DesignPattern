using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IosOpertionController : IOperation
    {
        public void PlayGame()
        {
            Console.WriteLine("Ios 系统游戏操作控制");
        }
    }
}
