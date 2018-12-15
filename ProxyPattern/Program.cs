using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理模式：给一个对象提供一个代理或占位符，并由代理对象来控制对原对象的访问
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*

           * 代理模式包含3个角色：
           * 
           * 1 Subject(抽象主题角色) 它申明了真实主题和代理主题的共同接口，这样一来在任何使用真实主题的地方都可以使用代理主题
           * 在正常情况下，他讲所有从客户端发来的请求委派到相应的子系统，传递给相应的子系统对象处理。
           * 
           * 2 Proxy（代理主题角色） 它包含了对真实主题的引用，从而可以任何时候操作真实主题对象；
           * 在代理主题角色提供了一个与真实主题角色相同的接口，以便在任何时候都可以代替真实主题；代理主题角色还可以控制对真实主题的使用，负责在需要的时候创建和删除真实主题对象，
           * 并对真实主题对象使用加以约束。通常，在代理主题角色中，客户端在调用所引用的真实主题操作之前或之后还需要执行其他操作，而不仅仅是单纯地调用真实主题
           * 
           * 3 RealSubject(真实主题角色) 它定义了代理角色所代表的真实对象，在真实主题角色中实现了真实的业务操作，客户端可以通过代理主题角色间接调用真实主题角色中定义的操作。

           */

            PermissionProxy proxy = new PermissionProxy(5,10);

            proxy.Detail();

            Console.WriteLine("---------华丽分割线------------");
            PermissionProxy pp = new PermissionProxy(0, 13);
            pp.Detail();

            Console.ReadLine();

        }
    }
}
