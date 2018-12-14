using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class UnSupportedShapeException:Exception
    {
        public UnSupportedShapeException()
        {
            Console.WriteLine("绘制图形发生异常");
        }
    }
}
