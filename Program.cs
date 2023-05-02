using System;
using System.Numerics;

namespace Study
{
    class Program
    {
        static BigInteger GetFactorial(BigInteger number)
        {
            if (number > 0 && number != 1)
            {
                return number * GetFactorial(number - 1);
            }
            else
            {
                return 1;
            }
        }
        static BigInteger GetPartialPermutation(BigInteger n, BigInteger m)
        {
            return GetFactorial(n) / GetFactorial(n - m);
        }
        static void Main(string[] args)
        {
            string choice;
            int numOfPossibleChars, numOfPasswordSymbols;

            Console.WriteLine("Select the number of symbols for your password: ");
            Console.WriteLine("1 - for 4 symbols");
            Console.WriteLine("2 - for 5 symbols");
            Console.WriteLine("3 - for 6 symbols");

            choice = Console.ReadLine();

            if (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("ENTER 1, 2 or 3!!!");
            }
            else
            {
                if (choice == "1") numOfPasswordSymbols = 4;
                else if (choice == "2") numOfPasswordSymbols = 5;
                else numOfPasswordSymbols = 6;

                Console.WriteLine("Select the characters that will be used to create the password: ");
                Console.WriteLine("1 - only digits");
                Console.WriteLine("2 - digits and lowercase letters");
                Console.WriteLine("3 - digits and letters");

                choice = Console.ReadLine();

                if (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.WriteLine("ENTER 1, 2 or 3!!!");
                }
                else
                {
                    if (choice == "1") numOfPossibleChars = 10;
                    else if (choice == "2") numOfPossibleChars = 36;
                    else numOfPossibleChars = 62;

                    Console.WriteLine($"The number of possible passwords: {GetPartialPermutation(numOfPossibleChars, numOfPasswordSymbols)}");
                }
            }
        }
    }
}