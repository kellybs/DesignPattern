using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 具体产品
    /// </summary>
    class Rectangle : Sharp
    {
        public void Draw()
        {
            Console.WriteLine("调用Rectangle的画图方法");
        }

        public void Erase()
        {
            Console.WriteLine("调用Rectangle的清楚方法");
        }
    }
}
