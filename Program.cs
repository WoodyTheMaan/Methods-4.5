using System;

namespace Methods_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usersInput = "";
            Console.WriteLine("Press '1' to run ASCII");
            Thread.Sleep(500);
            Console.WriteLine("Or press '2' to run ASCII");
            usersInput = Console.ReadLine();
            if (usersInput == "1")
            {
                theThreeASCII();
            }
            else if (usersInput == "2")
            {

            }
            else 
            {
                Console.WriteLine($"{usersInput} IS NOT A VALID INPUT");
                Console.WriteLine("Click enter to try again");
                Console.WriteLine();
               
            }
                while (true);
        }


        public static void theThreeASCII()
        {
            Console.WriteLine("HEllo");
        }
    }
}