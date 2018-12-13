using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    class Mouse : IObserver
    {
        private string name;

        public Mouse(string name,ISubject sub)
        {
            this.name = name;
            sub.AddObserver(this);
        }
        public void Update()
        {
            Console.WriteLine(this.name+"逃跑了!");
        }
    }
}
