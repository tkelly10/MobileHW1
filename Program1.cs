using System;
namespace MobileHwProgram1_2
{
    public class Program1
    {
        public Program1()
        {
            int num;
            string input;
            string input2;
            do
            {
                Console.WriteLine("Enter a number between 3 - 9");
                input = Console.ReadLine();
                num = int.Parse(input);

                for (int i = 1; i <= num; i++)
                {
                    for (int k = 1; k < num + 1; k++)
                    {
                        Console.Write("{0} ", (i * k));
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End:");
                input2 = Console.ReadLine();

                switch (input2)
                {
                    case "1":
                        {
                            for (int i = 1; i <= num; i++)
                            {
                                for (int k = num; k > 0; k--)
                                {
                                    Console.Write("{0} ", (i * k));
                                }
                                Console.WriteLine("\n");
                            }

                            break;
                        }
                    case "2":
                        {
                            for (int i = num; i >= 1; i--)
                            {
                                for (int k = 1; k <= num; k++)
                                {
                                    Console.Write("{0} ", (i * k));
                                }
                                Console.WriteLine("\n");
                            }

                            break;

                        }
                    case "3":
                        {
                            for (int i = 1; i <= num; i++)
                            {
                                for (int k = num; k > 0; k--)
                                {
                                    Console.Write("{0} ", (i * k));
                                }
                                Console.WriteLine("\n");
                            }

                            break;
                        }
                    case "4":
                        {
                            for (int i = num; i >= 1; i--)
                            {
                                for (int k = num; k > 0; k--)
                                {
                                    Console.Write("{0} ", (i * k));
                                }
                                Console.WriteLine("\n");
                            }

                            break;
                        }
                }


            } while (input2 != "5");

        }
    }
}
