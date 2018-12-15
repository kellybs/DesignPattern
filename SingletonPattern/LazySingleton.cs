using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class LazySingleton
    {
        private static LazySingleton instance = null;

        /// <summary>
        /// 程序运行时创建一个静态只读的辅助对象
        /// </summary>
        private static readonly object obj = new object();

        private LazySingleton() { }

        /// <summary>
        /// 双重检查 解决多线程问题
        /// </summary>
        /// <returns></returns>
        public static LazySingleton GetInstance()
        {
            // 第一重判读，实例是否存在，不存在加锁处理
            if (instance == null)
            {

                // 加锁的程序在某一刻只允许一个线程访问
                lock (obj)
                {
                    //第二重判断
                    if (instance == null)
                    {
                        //创建单例实例
                        instance = new LazySingleton();
                    }
                }
            }
            return instance;
        }

    }
}
