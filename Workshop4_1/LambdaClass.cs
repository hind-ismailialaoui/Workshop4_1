using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4_1
{
    internal class LambdaClass
    {
        Func<int, int> Carre = x => x * x;

        public void FaireLeCarre(int x)
        {
            int result = Carre(x);
            Console.WriteLine(result);

        }
    }
}
