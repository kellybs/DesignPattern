using System;

namespace AbstractFactory
{
    class Program
    {
        /// <summary>
        /// 抽象工厂：提供一个创建一系列相关或相互依赖对象的接口，而无须指定他们具体类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             * AbstractFactory(抽象工厂):它声明了一组用于创建一簇产品的方法，每一个方法对应一种产品
             * ConcreteFactory(具体工厂):它实现了在抽象工厂中声明创建产品的方法，生产一组具体产品，
             * 这些产品构成了一个产品簇，每一个产品都位于某个产品等级结构中
             * AbstractProduct(抽象产品):它为每种产品声明接口，在抽象产品中声明了产品所具有的业务方法
             * ConcreteProduct(具体产品):它定义具体工厂生产的具体产品对象，实现抽象产品接口中声明的业务方法
             */

            IControllerFactory factory = null;

            IInterface iif = null;

            IOperation io = null;

            factory = new IosFactory();

            iif = factory.CreateInterface();

            io = factory.CreateOperation();

            iif.Play();
            io.PlayGame();

            Console.ReadLine();


        }
    }
}
