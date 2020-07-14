using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Benz : ICar
    {
        public void Run()
        {
            Console.WriteLine("奔驰车启动了");
        }
    }
}
