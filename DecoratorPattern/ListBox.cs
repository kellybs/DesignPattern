using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 列表框类（具体构建类）
    /// </summary>
    class ListBox : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("显示列表框");
        }
    }
}
