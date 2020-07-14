using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace FactoryMethod
{
    class Start
    {
        static void Main(string[] args)
        {
            /*
            * 
          

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
