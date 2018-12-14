using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class ShapeFactory
    {
        /// <summary>
        /// 工厂类
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Sharp GetSharp(string type)
        {
            Sharp sharp = null;

            if (type.Equals("1"))
            {
                sharp = new Circle();
            }
            else if (type.Equals("2"))
            {
                sharp = new Triangle();
            }
            else if (type.Equals("3"))
            {
                sharp =new Rectangle();
            }
            else {
                throw new UnSupportedShapeException();
            }

            return sharp;
        }
    }
}
