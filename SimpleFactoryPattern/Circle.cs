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
    class Circle : Sharp
    {
        public void Draw()
        {
            Console.WriteLine("调用Circle的画图方法");
        }

        public void Erase()
        {
            Console.WriteLine("调用Circle的清楚方法");
        }
    }
}
