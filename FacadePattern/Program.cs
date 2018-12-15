using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 外观模式：为子系统中的一组接口提供一个统一的入口。外观模式定义了一个高层接口，这个接口使得这一子系统更加容易使用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*

            * 外观模式包含2个角色：
            * 
            * 1 Facade（外观角色） 在客户端可以调用他的方法，在外观角色中可以知道相关的（一个或者多个）子系统的功能和责任；
            * 在正常情况下，他讲所有从客户端发来的请求委派到相应的子系统，传递给相应的子系统对象处理。
            * 
            * 2 SubSystem（子系统角色）在软件系统中可以有一个或者多个子系统，每一个子系统可以不是一个单独的类，而是一个类的集合，它实现子系统的功能；

            */

            /*
             * 某软件公司为新开发的智能手机控制与管理软件提供一件备份功能，将通讯录，短信，照片，歌曲等资料一次性移动到存储介质
             * 
             */

            BackUpFacade facade = new BackUpFacade();
            facade.OneKeyBackup();
            Console.ReadLine();


        }
    }
}
