using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    class GreetingClass
    {
        public static void GreetingChinese(string name)
        {
            Console.WriteLine( "早上好，{0}", name );
        }

        public static void GreetingEnglish(string name)
        {
            Console.WriteLine("Good Morning,{0}", name);
        }

        public static void Greeting(string name, string language)
        {
            if (language == "中文")
            {
                Console.WriteLine("早上好，{0}", name);
            }
            else if (language == "english")
            {
                Console.WriteLine("Good Morning,{0}", name);
            }
            else
            {
                Console.WriteLine("输入语言有误");
            }
        }

        public static void Greeting(string name, DelegateClass.GreetingHandler handler)
        {
            handler.Invoke(name);
        }
    }

     

}
