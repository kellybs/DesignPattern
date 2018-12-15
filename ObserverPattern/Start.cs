using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者模式：定义对象之间的一种一对多依赖关系，使得每当一个对象状态发生改变时，其相关依赖对象都得到通知并被自动更新
    /// </summary>
    class Start
    {
        static void Main(string[] args)
        {
            /*
            * 
            * 观察者模式包含4个角色：
            * 
            * 1 Subject(目标)：目标又称主题，它是被观察的对象。它提供一些列方法来增加和删除观察者对象，同时定义了通知方法Notify()。目标类可以是接口，或者抽象类或者具体类
            * 2 ConcreteSubject（具体目标）： 具体目标是目标类的子类，通常包含经常发生改变的数据，当它的状态发送改变时将向它的各个观察者发出通知；
            *                                  同时它还实现了目标类中定义的抽象业务方法（如果有），如果无需扩展目标类，具体目标类则可省略。
            * 3 Observer（观察者）：观察者将对观察目标的改变做出反应，观察者一般定义为接口，该接口声明更新数据的方法Update（），因此又称为抽象观察者。
            * 4 ConcreteObserver(具体观察者)：在具体观察者中维护一个指向具体目标对象的引用，它存储具体观察者的有关状态，这些状态需要和具体目标的状态保持一致；它实现了在
            *                                  抽象观察者Observer中定义的Update方法。通常在实现时，可以调用具体目标类的Attach（）方法将自己添加到目标类的集合中或通过Detach（）方法将自己中目标类的集合中删除。
            * 
          

            */


            ISubject cat = new Cat();
            IObserver mouseA = new Mouse("米老鼠", cat);
            IObserver mouseB = new Mouse("bad mouse", cat);
            IObserver people = new Human("小李飞刀", cat);

            cat.Cry();
            Console.ReadLine();

            /*
             * 这是网上流行的面试题
             * 猫大叫一声，老鼠开始逃跑，主人被惊醒
             * 
             */ 
        }
    }
}
