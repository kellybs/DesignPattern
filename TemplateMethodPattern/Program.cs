using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /*
     * 模板方法：定义一个操作中的算法框架，而将一些步骤延迟到子类中。模板方法模式使得子类不改变一个算法的结构即可重定义该算法的某些特定步骤
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 AbstractClass(抽象类):在抽象类中定义了一些列基本操作,这些基本操作可以是具体的，也可以是抽象的，每一个基本操作对应算法的一个步骤，
             * 在其子类中可以重定义或实现 这些步骤。同时，在抽象类中实现了一个模板方法，用于定义一个算法的框架，模板方法不仅可以调用在抽象类中实现
             * 的基本方法，也可以调用在抽象类的子类中实现的基本方法，还可以调用其他对象中的方法。
             * 
             * 2 ConcerteClass(具体子类):它是抽象类的子类，用于实现在父类中声明的抽象基本操作，以完成子类特定算法的步骤，可以覆盖在父类中实现
             * 具体操作。
             * 
             * 
             * 
             */

            TemplateBank tmp = new DepositBusiness();

            tmp.Process();

            Console.ReadLine();
        }
    }
}
