using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace prep_PE
{
    internal class Program
    {
        //Brian Teruya
        //Practical exam prep
        //10/20/25

        public static int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        public static bool Greaterorequal(int num1)
        {
            if (num1 >= 0)
            {
                Console.Write("True");
                return (true);
            }
            else
            {
                Console.Write("False");
                return (false);
            }
        }
        public static string larger(int respint)
        {

            if ((respint > 0) && (respint <= 100))
            {
                Console.WriteLine($"your new number is {respint + 10}.");
            }
            else 
            {
                do
                {
                    Console.WriteLine("oops! invalid value! try again:");
                    respint = Convert.ToInt32(Console.ReadLine());
                    larger(respint);
                } while (respint <= 0 && (respint > 100));
               
            }
            
        }
        static void Main(string[] args)
        {
            //PREP START
            //#1
            Console.WriteLine($"1 - 3 = {Difference(1, 3)}");
            Console.WriteLine($"7 - 4 = {Difference(76, 4)}");
            Console.WriteLine($"-9 - 45 = {Difference(-9, 45)}");
            Console.WriteLine($"5 - 5 = {Difference(5, 5)}");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            //2


            Console.WriteLine($"Is {5}>= 0? " + Greaterorequal(5));
            Console.WriteLine($"Is {0}>= 0? " + Greaterorequal(0));
            Console.WriteLine($"Is {-2}>= 0? " + Greaterorequal(-2));
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            //3

            Console.WriteLine("enter a whole number between 1 and 100");
            
            int respint = Convert.ToInt32(Console.ReadLine());
            larger(respint);
            
           


                //4


            
        }
    }
}
