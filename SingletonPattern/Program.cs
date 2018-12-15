using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式：确保一个类只有一个实例，并提供一个全局访问点来访问这个唯一实例
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
          一个类只有一个实例，并提供一个全局访问点来访问这个唯一实例
           * 
           * 3要点：
           * 1 某个类只能有一个实例；
           * 2 他必须自行创建这个实例
           * 3 他必须向整个系统提供这个实例
           * 
           * 实现单例模式注意以下3点
           * 
           * 1 单例类构造函数的可见性为private
           * 2 提供一个类型为自身的静态私有成员变量。
           * 3 提供一个公有的静态工厂方法。
           * 


           */

            /* 创建4个对象，但是实际上是同一个对象 */
            LoadBanlancer obj1, obj2, obj3, obj4;
            obj1 = LoadBanlancer.GetLoadBanlance();
            obj2 = LoadBanlancer.GetLoadBanlance();
            obj3 = LoadBanlancer.GetLoadBanlance();
            obj4 = LoadBanlancer.GetLoadBanlance();

            if (obj4 == obj3 && obj3 == obj2 && obj2 == obj1)
            {
                Console.WriteLine("服务器具有唯一性");
            }

            obj1.AddServer("Server 1");
            obj1.AddServer("Server 2");
            obj1.AddServer("Server 3");
            obj1.AddServer("Server 4");

            for (int i = 0; i < 50; i++)
            {
                string server = obj1.GetServer();
                Console.WriteLine("分发请求至服务器：" + server);
            }


            Console.ReadLine();
        }
    }
}
