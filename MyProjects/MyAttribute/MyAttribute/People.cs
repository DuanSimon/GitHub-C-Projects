using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    [Customer("Simon", 1.0)]
    public class People
    {
        public string Name;
        public int Id;
        public People()
        { 
        
        }
    }
}
