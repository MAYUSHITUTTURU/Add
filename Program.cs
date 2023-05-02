using System;

namespace Study;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select an acceptable number of password characters(4-6):");
        Console.Write("Type: ");
        string text1 = Console.ReadLine();
        int a = int.Parse(text1);

        Console.WriteLine("Select valid characters: \n 1: numbers \n 2: numbers and 1 letter \n 3: only letters"); // 26 letters (eng alphabet)
        Console.Write("Type: ");
        string text2 = Console.ReadLine();
        int g = int.Parse(text2);

        int b = (int)Math.Pow(10, a);
        int f = (int)Math.Pow(10, a - 1) * 26;
        int r = (int)Math.Pow(26, a);

        if (a >= 4 && a <= 6)
        {
            switch (a)
            {
                case 4:
                    if (g >= 1 && g <= 3)
                    {
                        switch (g)
                        {
                            case 1:
                                Console.WriteLine("Number of password variants - " + b);
                                break;
                            case 2:
                                Console.WriteLine("Number of password variants with 1 letter - " + f);
                                break;
                            case 3:
                                Console.WriteLine("Number of password variants with full letter - " + r);
                                break;
                            default:
                                Console.WriteLine("Error type");
                                break;
                        }
                    }
                    break;

                case 5:
                    if (g >= 1 && g <= 3)
                    {
                        switch (g)
                        {
                            case 1:
                                Console.WriteLine("Number of password variants - " + b);
                                break;
                            case 2:
                                Console.WriteLine("Number of password variants with 1 letter - " + f);
                                break;
                            case 3:
                                Console.WriteLine("Number of password variants with full letter - " + r);
                                break;
                            default:
                                Console.WriteLine("Error type");
                                break;
                        }
                    }
                    break;

                case 6:
                    if (g >= 1 && g <= 3)
                    {
                        switch (g)
                        {
                            case 1:
                                Console.WriteLine("Number of password variants - " + b);
                                break;
                            case 2:
                                Console.WriteLine("Number of password variants with 1 letter - " + f);
                                break;
                            case 3:
                                Console.WriteLine("Number of password variants with full letter - " + r);
                                break;
                            default:
                                Console.WriteLine("Error type");
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("none");
                    break;
            }
        }
    }
}