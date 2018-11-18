using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MyMultithreading
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***************************************************************************************************");
            for (int i = 0; i < 5; i++)
            {
                string name = string.Format("【同步操作】-- {0}", i);
                DoSomething(name);
            }
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// 异步、多线程、并发在C#中具有相同的含义；通过委托来实现异步；
        /// 特点：
        /// 1、各个线程同时进行，不会卡在主线程
        /// 2、各个线程随机顺序
        /// 3、处理速度更快，但是更占资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsync_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***************************************************************************************************");
            DoSomethingHandler method = new DoSomethingHandler(DoSomething);
            for (int i = 0; i < 5; i++)
            {
                string name = string.Format("【异步操作】-- {0}", i);
                method.BeginInvoke(name, null, null);
            }
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private delegate void DoSomethingHandler(string name);
        private void DoSomething(string name)
        {
            Console.WriteLine("{0} {1}开始执行，当前线程ID={2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), name, Thread.CurrentThread.ManagedThreadId);
            long lResult = 0;
            for (long i = 0; i < 100000000; i++)
            {
                lResult += i;
            }
            Thread.Sleep(2000);
            Console.WriteLine("{0} {1}结束执行，当前线程ID={2}, 计算结果={3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), name, Thread.CurrentThread.ManagedThreadId, lResult);
        }
    }
}
