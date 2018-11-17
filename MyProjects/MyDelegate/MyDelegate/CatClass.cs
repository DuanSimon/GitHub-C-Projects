using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    class CatClass
    {
        public DelegateClass.CatMiaoHandler CatMiaoHandlerMethod;         //委托实例化
        public event DelegateClass.CatMiaoHandler CatMiaoHandlerEvent;    //事件是委托一个实例化  
        public void Miao()
        {
            Console.WriteLine("猫，喵了一声");
            if (CatMiaoHandlerEvent != null)
            {
                CatMiaoHandlerEvent();
            }
        }
    }
}
