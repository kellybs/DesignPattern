using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AndroidOpertionController : IOperation
    {
        public void PlayGame()
        {
            Console.WriteLine("android 游戏操作控制");
        }
    }
}
