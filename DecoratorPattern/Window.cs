using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 窗体类（具体构建类）
    /// </summary>
    class Window : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("显示窗体");
        }
    }
}
