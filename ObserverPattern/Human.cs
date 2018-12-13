using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    ///  具体观察者
    /// </summary>
    class Human : IObserver
    {
        private string name;
        public Human(string name ,ISubject sub)
        {
            this.name = name;
            sub.AddObserver(this);
        }
        public void Update()
        {
            Console.WriteLine(this.name+"从梦中惊醒");
        }
    }
}
