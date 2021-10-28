using System;

namespace INLAMNING
{
    class Program
    {
        static void Main(string[] args)
        {

            static void WelcomeApp()
            {
                Console.WriteLine("Välkommen, skriv in ditt namn!");

            }

            static void Main(string[] args)
            {
                bool Finish = true;
                double result;
                char Count;

                List<string> Historik = new List<string>();

                WelcomeApp();

                string name = Console.ReadLine();

                Console.WriteLine("Hej " + name);

                while (Finish)

                {
                    Console.WriteLine("Skriv in ett tal");
                    int tal1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Skriv ett till tal");
                    int tal2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Välj operator: ");
                    Count = Convert.ToChar(Console.ReadLine());

                    if (Count == '+')
                    {
                        result = tal1 + tal2;
                        Console.WriteLine("{0}{1}{2}", tal1, tal2, result);
                        Historik.Add(string.Format("{0} + {1} = {2}", tal1, tal2, result));
                    }
                    else if (Count == '*')
                    {
                        result = tal1 * tal2;
                        Console.WriteLine(result);
                        Historik.Add(string.Format("{0} * {1} = {2}", tal1, tal2, result));
                    }
                    else if (Count == '-')
                    {
                        result = tal1 - tal2;
                        Console.WriteLine(result);
                        Historik.Add(string.Format("{0} - {1} = {2}", tal1, tal2, result));

                    }
                    else if (Count == '/')
                    {
                        result = tal1 / tal2;
                        Console.WriteLine(result);
                        Historik.Add(string.Format("{0} / {1} = {2}", tal1, tal2, result));
                    }


                    Console.WriteLine(" Vill du köra om? [JA(/NEJ] ");
                    string svar = Console.ReadLine();


                    if (svar == "NEJ")
                    {
                        Console.WriteLine("vill du se tidiagre uträknigar? [JA / NEJ]");
                        string choice = Console.ReadLine();

                        if (choice == "JA")
                        {
                            foreach (string item in Historik)
                            {
                                Console.WriteLine("Uträkning är: {0}", item);
                            }
                        }
                        else
                        {
                            Finish = false;
                        }
                    }



                }









            }









        }
    }
}
    }
}
