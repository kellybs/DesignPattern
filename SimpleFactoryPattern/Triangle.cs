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
    class Triangle :Sharp
    {
        public void Draw()
        {
            Console.WriteLine("调用Triangle的画图方法");
        }

        public void Erase()
        {
            Console.WriteLine("调用Triangle的清楚方法");
        }
    }
}
