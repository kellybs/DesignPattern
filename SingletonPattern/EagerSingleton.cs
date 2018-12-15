using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 饿汉式（解决多线程问题，调用速度和反应时间，优于懒汉式，但是加载时间可能较长）
    /// </summary>
    class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();
        private EagerSingleton() { }

        public static EagerSingleton GetInstance()
        {
            return instance;
        }
    }
}
