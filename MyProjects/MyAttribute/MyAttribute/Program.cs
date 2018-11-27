using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People()
            { 
                Id = 11,
                Name = "芈月"
            };

            Type type = typeof(People);
            object[] attributeArray = type.GetCustomAttributes(typeof(CustomerAttribute), true);
            if(attributeArray !=  null && attributeArray.Length > 0)
            {
                ((CustomerAttribute)(attributeArray[0])).show();
            }

            Console.ReadLine();
        }
    }
}
