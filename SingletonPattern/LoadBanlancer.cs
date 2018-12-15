using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式
    /// </summary>
    class LoadBanlancer
    {

        /// <summary>
        /// 私有成员静态变量，存储唯一实例
        /// </summary>
        private static LoadBanlancer instance;

        /// <summary>
        /// 服务器集合
        /// </summary>
        private List<string> serverList = new List<string>();

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private LoadBanlancer()
        {

        }

        /// <summary>
        /// 共有静态程序方法，返回唯一实例
        /// </summary>
        /// <returns></returns>
        public static LoadBanlancer GetLoadBanlance()
        {
            if (instance == null)
            {
                instance = new LoadBanlancer();
            }
            return instance;
        }

        /// <summary>
        /// 添加服务器
        /// </summary>
        /// <param name="server"></param>
        public void AddServer(string server)
        {
            serverList.Add(server);
        }

        /// <summary>
        /// 删除服务器
        /// </summary>
        /// <param name="server"></param>
        public void RemoveServer(string server)
        {
            serverList.Remove(server);
        }

        /// <summary>
        /// 随机获取服务器
        /// </summary>
        /// <returns></returns>
        public string GetServer()
        {
            Random rnd = new Random();
            int i = rnd.Next(serverList.Count());
            return serverList[i].ToString();
        }
    }
}
