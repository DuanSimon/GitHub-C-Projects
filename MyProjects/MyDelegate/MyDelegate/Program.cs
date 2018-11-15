using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingClass.GreetingChinese("小花");
            GreetingClass.GreetingEnglish("simon");
            GreetingClass.Greeting("小北", "中文");
            DelegateClass.GreetingHandler handlerChinese = new DelegateClass.GreetingHandler(GreetingClass.GreetingChinese);
            GreetingClass.Greeting("小美", handlerChinese);

            Action<string> act01 = name => Console.WriteLine("你好，{0}", name);
            act01.Invoke("小甜甜");

            Console.ReadLine();           
        }
    }
}
