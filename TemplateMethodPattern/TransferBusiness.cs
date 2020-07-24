using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class TransferBusiness : TemplateBank
    {
        public override int BankBusiness()
        {
            Console.WriteLine("办理转账业务");

            return 4;
        }
    }
}
