using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 抽象主题
    /// </summary>
    interface ISubject
    {
        void Cry();
        void AddObserver(IObserver obs);
    }
}
