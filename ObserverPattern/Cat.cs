using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 具体主题
    /// </summary>
    class Cat : ISubject
    {
        List<IObserver> list;
        public Cat()
        {
            list = new List<IObserver>();
        }
        public void AddObserver(IObserver obs)
        {
            list.Add(obs);
        }

        public void Cry()
        {
            foreach (var item in list)
            {
                item.Update();
            }
        }
    }
}
