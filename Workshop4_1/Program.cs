using System;

namespace Workshop4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pour la somme//
            DeleguateClass deleguateClass = new DeleguateClass();
            deleguateClass.ManipulerNombres(1, 3);

            //Pour le carre//
            LambdaClass lambdaClass= new LambdaClass();
            lambdaClass.FaireLeCarre(5);

            //Pour L'ulilisation de Anonymous Type//

            AnonymousClass @Person = new AnonymousClass() { Age = 20, Prenom = "ind" }; //Ici j'ai créé mon objet
            Console.WriteLine("Je m'appelle " + @Person.Prenom + " j'ai  " + @Person.Age + "ans.");

            var @ettonnom = new AnonymousClass() { Family = "Ismaili Alaloui" }; // Une autre manière est d'utiliser var 
            Console.WriteLine("Mon nom de famille est "+ ettonnom.Family +".");

            //Pour la question 4//

            // Pour créer des objets on fait comme ça:
            A objet1 = new A(); //là on instancie
            objet1.ma(); // ici on apelle la méthode

            B objet2=new B(); 
            objet2.mb();

            // Pour créer une instance de mon delay:
            Question4 questioninstance = new Question4(methodeX); //ici je fais ref à la méthode
            questioninstance();

            static void methodeX() // et voici la méthode
            {
                Console.WriteLine("La méthode est ok");
            }

            //Déclarer un tableau depuis mon délégué
            Question4 questiontableau = new Question4(methodeY);
            questiontableau();

            static void methodeY()
            {
                int[] nombre = { 1, 2, 3, 4, 5 };
                Console.WriteLine(nombre[0]);
            }

            //Pour déclarer un délégué muticast depuis mon délégué
            Question4 questionmulticast = new Question4(methodeZ);
            questionmulticast += methodeA;
            questionmulticast();


            static void methodeZ()
            {
                Console.WriteLine("je suis le premier élément");
            }

            static void methodeA()
            {
                Console.WriteLine("je suis le second élément");
            }


        }

    }
}