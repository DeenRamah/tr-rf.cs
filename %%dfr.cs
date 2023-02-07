using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class myProgram
    {
        // static void Main(string[] args)
        static void Main(string[] args)
        {

            int p = 100;
            int h = 900;


            Console.WriteLine(Math.Max(p, h));

            string myname = "Puny mf";
            Console.WriteLine(myname);

            int herNum = 15;
            herNum = 30;
            Console.WriteLine(herNum);
            //when finding the aquire root
            Console.WriteLine(Math.Sqrt(81));
            //when rounding off to the next integer

            Console.WriteLine(Math.Round(2.22));


            string firstName = "John";
            string lastName = "Mkuu";

            string LastName = firstName + lastName;

            Console.WriteLine(LastName);

            //using the string interpolation method to concatenate two strings

            string Name = "Haga";
            string Name1 = "puny";
            string nname = $"My full name is:{Name} {Name1}";

            Console.WriteLine(nname);

            //accessing the value of each character in a statement like

            string mem = "Lambistic";

            Console.WriteLine(mem[0]);

            //printing the length of a property

            string txt = "Motherfucker";

            Console.WriteLine(txt.Length);

            //when displaying the letter to uppercase or lowercase

            string mkuu = "Lover Boy";
            Console.WriteLine(mkuu.ToUpper());


            //using boolean structure in a program

            bool isCodingPuny = false;
            bool isSimpingallowed = false;
            bool isFeminineWrong = true;

            Console.WriteLine(isFeminineWrong);
            Console.WriteLine(isSimpingallowed);
            Console.WriteLine(isCodingPuny);


            //when you like to find true in each statement like for example in this program

            int i = 10;
            int t = 7;

            Console.WriteLine(i > t);

            int w = 100;
            int s = 50;

            if( s > w)
                {
                Console.WriteLine("Puny and Pusified");
            }
            else
            {
                Console.WriteLine("Lambistias Insignificante");
            }


            //also when using loops you can have a code like this and learn

            int n = 50;
            int f = 50;

            if(n >= f)
            {
                Console.WriteLine("Welcome Puny");
            }
            else if (f >=n)
            {
                Console.WriteLine("Puny Mf");
            }
            else
            {
                Console.WriteLine("Puny Lambistias");
            }

       

            int r = 50;
            int e = 50;

            if (r>e)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("Dog");
            }
        }
    }
}