using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loopen
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i++ < 100)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");

            //övning2
            Console.Write("Skriv in ett lösenord");
            Console.Write(" ");
            string inmatat = Console.ReadLine();


            while (inmatat != "ost") 
            {
                Console.WriteLine("Fel lösenord");
                inmatat = Console.ReadLine();
            }

            //övning3
            int n = 1;
            while (n++ < 100)
            {
                Console.WriteLine(n);
                
            }
            //övning4
            int p = 10;
            while (p-- < 1)
            {
                Console.WriteLine(p);
               
            }

            //övning5
            //while (true)
            //{
            //    Console.WriteLine("tjenare mannen");
            //}

            //övning6

            Console.WriteLine("Gissa ett tal mellan 1 till 100");
            string g = Console.ReadLine();
            int tal = int.Parse(g);
            while (tal != 88)
            {
                g = Console.ReadLine();
                tal = int.Parse(g);
                if (tal < 88)
                {
                    Console.WriteLine("För lågt!");
                }
                else if (tal > 88)
                {
                    Console.WriteLine("För högt!");
                }
                else
                {
                    Console.WriteLine("Rätt!");
                }
            }

        }
    }

    }

