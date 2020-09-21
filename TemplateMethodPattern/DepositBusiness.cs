using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class DepositBusiness : TemplateBank
    {
        public override int BankBusiness()
        {
            Console.WriteLine("办理存款业务");

            return 3;
        }
    }
}
