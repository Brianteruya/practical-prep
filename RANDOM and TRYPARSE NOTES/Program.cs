namespace RANDOM_and_TRYPARSE_NOTES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * NOTES START
             * 
             * TRYPARSE()
             * (parsing without runtime errors)
             * REVIEW:parsing converts a string to a primitive data type
             * string --> int/bool/double/character/etc
             * now how can we parse data from a string without the program crashing upon invalid input?
             * 
             * INTRODUCING TRYPARSE!!!
             * a new parsing method provides anothe rway to parse data
             * 
             * Any type with a parse also has a TryParse()
             * ex
             * int.TryParse()
             * double.TryParse()
             * float.TryParse()
             * ETC
             * the way works is that its almlost like a conditional.
             * when the parse is successful, it can be tied to a bool, where the result would be true.
             * however if the parse is failed, it can be tied to a bool and will result to false.
             * it returns a bool value!
             * 
             * ex
             * 
             */
            Console.WriteLine("enter a value between 1 and 10");
            bool parsesuccess = int.TryParse(Console.ReadLine()!, out int result);

            while (parsesuccess=false||result<1||result>10)
            {
                Console.WriteLine("Try again! enter a number between 1 and 10");
                parsesuccess = int.TryParse(Console.ReadLine()!, out result);
            }
            /*
             *holy shit it works
             *methods can only return a single value; either true of false.
             *but HOW can we get the result out of theparse??????
             *
             *using the out!                                         v right here
             *bool parsesuccess = int.TryParse(Console.ReadLine()!, out int result);
             *
             *this is a special parameter that recieves new data as a method runs!
             *Results in that a variable containing a different value after method execution.
             *always preceded with the keyword "out"
             *
             *RANDOMS
             *random numbers are very important for games. it gives the sense of a gamble or maybe "luck"
             *now how is a random number generator truly random?
             *
             *its difficult  to mathematically calculate random values...
             *there is an algorithm that allows computers to generate "Pseudo-random" numbers
             *
             *how does random work.
             *
             *first declare a random object and then ask it for a ranbdom number
            EX*/

            Random myRNG = new Random();

                for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myRNG.Next(5, 101)); //ranges from 5 to 101
            }

            /*quite simple! you can use the range to exclude positive or negative numbers, and the range can go up to 2.14 bil using int.MaxValue or int.MinValue

             *
             * NOTES END
             */
        }
    }
}
