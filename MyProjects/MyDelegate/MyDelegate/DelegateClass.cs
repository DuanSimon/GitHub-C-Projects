using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    class DelegateClass
    {
        public delegate void GreetingHandler(string name);
        public delegate void CatMiaoHandler();                  //声明一个委托，委托是一种类型
    }
}
