using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AndroidFactory : IControllerFactory
    {
        public IInterface CreateInterface()
        {
           
            return new AndroidInterfaceController();
        }

        public IOperation CreateOperation()
        {
            return new AndroidOpertionController();
        }
    }
}
