using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4_1
{
    internal class DeleguateClass
    {
        private delegate int Methode(int v1, int v2); //déclare notre délégué qui s'appelle methode

        private int somme(int v1, int v2)
        {
            return v1 + v2;
        }

        public void ManipulerNombres(int v3, int v4)
        {

            Methode method = somme;
            int result = method(v3,v4);
            Console.WriteLine(result);
        }



    }
}
