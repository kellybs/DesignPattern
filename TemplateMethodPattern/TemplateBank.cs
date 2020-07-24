using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class TemplateBank
    {
        void TakeNumber()
        {
            Console.WriteLine("已经取到号码了");
        }

        public abstract int BankBusiness();

        void Evaluate(int score)
        {
            Console.WriteLine($"用户评分：{score}");
        }

        public virtual bool IsScore()
        {
            return true;
        }

        public void Process()
        {
            TakeNumber();
            int result=BankBusiness();

            if (IsScore())
            {
                Evaluate(result);
            }
            
        }
    }
}
