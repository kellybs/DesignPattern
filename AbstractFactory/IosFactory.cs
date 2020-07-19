using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IosFactory : IControllerFactory
    {
        public IInterface CreateInterface()
        {
            return new IosInterfaceController();
        }

        public IOperation CreateOperation()
        {
            return new IosOpertionController();
        }
    }
}
