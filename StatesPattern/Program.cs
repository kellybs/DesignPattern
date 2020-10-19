using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatesPattern
{
    /// <summary>
    /// 状态模式：允许一个对象在其内部状态改变时改变它的行为。对象看起来似乎修改它的类。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 状态模式 包含3个角色
             * Context(环境类)：环境类又称为上下文类，它是拥有多种状态++++的对象。
             * State(抽象状态类)：它用于定义一个接口以封装与环境类的一个特定状态相关的行为，再抽象状态类中声明了各种不同状态对应的方法，而在其子类中实现这些方法，
             * 由于不同状态下对象的行为可能不同，因此在不同子类中方法的实现可能存在不同，相同方法可以写在抽象状态类中
             * ConcreteState(具体状态类):它是抽象状态类的子类，每一个具体状态类实现一个与环境类的一个状态相关的行为，对应环境类的一个具体状态，不同的具体状态类其行为有所不同
             */


            PlayContext play = new PlayContext();
            play.ChangeState(2, 1);

            Console.WriteLine("----------------------------------------");

            play.ChangeState(3, 0);
            Console.WriteLine("----------------------------------------");

            play.ChangeState(4, 1);

            Console.WriteLine("----------------------------------------");

            play.ChangeState(1, 1);

            Console.ReadLine();
        }
    }
}
