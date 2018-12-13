using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    interface IObserver
    {
        void Update();
    }
}
