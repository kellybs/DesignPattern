using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
namespace StrategyPattern
{
    /// <summary>
    /// 策略模式：定义一些列算法，将每一个算法封装起来，并让他们可以相互替换
    ///           让算法可以独立于使用它的客户变化
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3个角色：
             *      1 Context（环境类）：环境类是使用算法的角色，它在解决某个问题（即实现某个给功能）时可以采用多种策略。
             *                           在环境类中维持一个对抽象策略类的引用实例，用于定义采用的策略
             *      2 Strategy（抽象策略类）：抽象策略类为所支持的算法声明了抽象方法，是所有策略类的父类，它可以是抽象类或具体类，也可以是接口
             *      3 ConcreteStrategy（具体策略类）：具体策略类实现了在抽象类中声明的算法，在运行时，具体策略类对象将覆盖在环境类中定义的抽象策略类引用，使用一种具体的算法实现某个业务功能。
             *      
             */



            /* 某系统需要对用户的密码进行加密(凯撒加密，求模加密)  */

            //读取配置文件
            string value = Common.StringHelp.GetConfigValue("Ciphertype");

            //反射生产具体加密对象
            ICipher cipher = (ICipher)Assembly.Load("StrategyPattern").CreateInstance(value);

            DataOperation dataOperation = new DataOperation(cipher);
            dataOperation.ShowResult();

            Console.ReadLine();
        }
    }
}
