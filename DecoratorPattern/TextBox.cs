using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 文本框类(具体构建类)
    /// </summary>
    class TextBox : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("显示文本框");
        }
    }
}
