using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4_1
{
    //Je rajoute un type delegate de signature void/void
    public delegate void Question4();

    public delegate void delg();

    public class A
    {
        public void ma()
        {
            Console.WriteLine("ma");
        }
    }

    public class B
    {
        public void mb() 
        {
            Console.WriteLine("mb");
        }
    }


}
