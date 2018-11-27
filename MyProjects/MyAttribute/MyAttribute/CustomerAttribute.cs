using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    public class CustomerAttribute : Attribute
    {
        public string Anthor = "";
        public double Version = 1.0;
        public CustomerAttribute()
        { 
        
        }
        public CustomerAttribute(string anthor)
        {
            this.Anthor = anthor;
        }
        public CustomerAttribute(string anthor, double version)
        {
            this.Anthor = anthor;
            this.Version = version;
        }
        public int Id { set; get; }
        public void show()
        {
            Console.WriteLine("这是{0}开发的程序{1}版本",this.Anthor, this.Version);
        }
    }
}
