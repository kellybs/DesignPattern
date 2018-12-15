using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
           * 
           * 说明：定义一个工厂类，他可以根据参数的不同返回不同类的实例，被创建的实例通常都具有共同的父类
           * 
           * 简单工厂模式包含3个角色：
           * 1 Factory(工厂角色)：工厂角色即工厂类，它是简单工厂模式的核心，负责实现创建所有产品的实例的内部逻辑；工厂类可以直接被外部调用，创建所需产品对象
           *              在工厂类中提供静态的工厂方法FactoryMethod(),它返回类型为抽象产品类型的Product.
           * 2 Product(抽象产品角色)：它是工厂类所创建的所有对象的父类，封装了各种产品对象的公共方法，它的引入提高系统灵活性
           * 
           * 3 ConcreteProduct(具体产品角色)：它是简单工厂模式创建目标，所有被创建的对象都充当这个角色某个具体类的实例。每一个具体产品角色都继承了抽象产品角色，
           *              需要实现抽象在抽象产品中声明的抽象方法。
           * 优点：

              简单工厂模式能够根据外界给定的信息，决定究竟应该创建哪个具体类的对象。通过它，外界可以从直接创建具体产品对象的尴尬局面中摆脱出来。
              外界与具体类隔离开来，偶合性低。
              明确区分了各自的职责和权力，有利于整个软件体系结构的优化。

              缺点：

              工厂类集中了所有实例的创建逻辑，容易违反GRASPR的高内聚的责任分配原则 
              虽然简单工厂模式能够适应一定的变化，但是它所能解决的问题是远远有限的。它所能创建的类只能是事先教考虑到的，如果需要添加新的类，则就需要改变工厂类了

              应用场景：

              当工厂类负责创建的对象比较少时可以考虑使用简单工厂模式
              客户如果只知道传入工厂类的参数，对于如何创建对象的逻辑不关心时可以考虑使用简单工厂模式 

           */
          

            string type = ConfigurationManager.AppSettings["types"];

            var result = ShapeFactory.GetSharp(type);
            result.Draw();
            result.Erase();

            Console.ReadLine();
        }
    }
}
