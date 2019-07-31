using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 自己写出现的问题
/// 1.符合委托签名的方法(即委托的操作)需要声明为public
/// 2.委托可以声明在命名空间下，以实现多个类可使用
/// 3.代码要写在方法中
/// </summary>
namespace Chapter02
{
    delegate void PrintDel(string printMessage);
    class MySimpleDelegateUse
    {
        public static event PrintDel PrintEvent;
        static void Main()
        {
            MyEventTest me = new MyEventTest();
            PrintEvent("haha");

            //PrintDel p1, p2, p3;
            //MyPerson york = new MyPerson("york");
            //p1 = new PrintDel(york.MyPersonPrint);
            //MyPerson xuxu = new MyPerson("xuxu");
            //p2 = new PrintDel(xuxu.MyPersonPrint);
            //p3 = new PrintDel(MyBackground.MyBackgroundPrint);
            ////p1 += p2;
            //p1 = (PrintDel)Delegate.Combine(p1, p2);
            //p1 += p3;
            //p1 -= p2;
            //p1("hahaha");
            //p1.Invoke("haha");
            //p2("hehe");
            //p3("oo");

            //PrintDel p;
            //MyPerson york = new MyPerson("york");
            //p = new PrintDel(york.MyPersonPrint);
            ////Delegate.
            //p("haha");


            Console.ReadKey();
        }
    }

    class MyEventTest
    {
        public MyEventTest()
        {
            MyPerson p = new MyPerson("york");
            MySimpleDelegateUse.PrintEvent += p.MyPersonPrint;
        }
        
    }

    class MyPerson
    {
        public MyPerson(string name)
        {
            Name = name;
        }
        string Name { get; set; }
        public void MyPersonPrint(string message)
        {
            Console.WriteLine("{0}:{1}", Name, message);
        }

    }

    class MyBackground
    {
        public static void MyBackgroundPrint(string message)
        {
            Console.WriteLine(message);
        }
    }
}
