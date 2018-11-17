using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //委托测试
            Console.WriteLine("——————委托测试——————");
            GreetingClass.GreetingChinese("小花");
            GreetingClass.GreetingEnglish("simon");
            GreetingClass.Greeting("小北", "中文");
            DelegateClass.GreetingHandler handlerChinese = new DelegateClass.GreetingHandler(GreetingClass.GreetingChinese);
            GreetingClass.Greeting("小美", handlerChinese);
            
            //Lamda表达式测试
            Console.WriteLine("——————Lamda测试——————");
            Action<string> act01 = name => Console.WriteLine("你好，{0}", name);
            act01.Invoke("小甜甜");
            act01("美女");
            
            //多播委托测试
            Console.WriteLine("——————多播委托测试——————");
            CatClass myCat01 = new CatClass();
            myCat01.Miao();
            myCat01.CatMiaoHandlerMethod = new DelegateClass.CatMiaoHandler(DogClass.Wang);       //委托实例被初始化
            myCat01.CatMiaoHandlerMethod += PersonClass.WakeUp;
            myCat01.CatMiaoHandlerMethod();                                            //委托实例，可以被外部调用
            
            //事件测试
            //EVENT 事件是委托的实例，委托是一种类型
            //EVENT 1、不能被初始化（不能之间=new(),避免直接=null，使得其他人的注册失效），
            //EVENT 2、不能被外部调用，只能内部调用，目的是进行权限控制
            //以上两条特性都是为了进行权限控制
            Console.WriteLine("——————事件测试——————");
            CatClass myCat02 = new CatClass();
            myCat02.Miao();
            //newCat.CatMiaoHandlerEvent = new CatMiaoHandler(DogClass.Wang);       //EVENT 不能被初始化
            myCat02.CatMiaoHandlerEvent += DogClass.Wang;
            myCat02.CatMiaoHandlerEvent += PersonClass.WakeUp;
            //newCat.CatMiaoHandlerEvent();                                         //EVENT 不能被外部调用，只能内部调用
            myCat02.Miao();
            myCat02.CatMiaoHandlerEvent -= DogClass.Wang;
            myCat02.Miao();

            Console.ReadLine();           
        }
    }
}
