using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BenzFactory : ICarFactory
    {
        public ICar GetCar()
        {
            ICar obj = new Benz();
            return obj;
        }
    }
}
