using System;
using System.Configuration;
using System.Reflection;

namespace FactoryMethod
{
    class Start
    {
        static void Main(string[] args)
        {
            /*
            
            * 工厂方法：定义一个用户创建对象的接口，但是让子类决定将哪一个类实例化。工厂方法模式让一个类的实例化延迟到其子类          

            */


            //ICarFactory carFactory = new BmwFactory();
            //ICar car = carFactory.GetCar();

            //car.Run();

            ICarFactory carFactory;
            ICar car;

            string factory = ConfigurationManager.AppSettings["factory"];

            carFactory = (ICarFactory)Assembly.Load("FactoryMethod").CreateInstance(factory);

            car = carFactory.GetCar();
            car.Run();

          
            Console.ReadLine();

          
        }
    }
}
