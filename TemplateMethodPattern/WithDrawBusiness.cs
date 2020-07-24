using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class WithDrawBusiness : TemplateBank
    {
        public override int BankBusiness()
        {
            Console.WriteLine("办理取款业务");

            return 5;
        }

        public override bool IsScore()
        {
            return false;
        }
    }
}
