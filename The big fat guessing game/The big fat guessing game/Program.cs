using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_big_fat_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;

            Console.WriteLine("Welcome to the Big Fat guessing game!");
            Console.WriteLine("Please eneter a number between 1-10");
            Console.WriteLine("------------------------------------");

            Random rnd = new Random();
            int Number = rnd.Next(1, 10);

            List<int> Guesses = new List<int>();

      
            int g = (int.Parse(Console.ReadLine()));
            Guesses.Add(g);


           

            while (g != Number)
            {
               

                if (g < Number)
                {
                    Console.WriteLine("Too low !");
                }
                else if (g > Number)
                {
                    Console.WriteLine("Too high !");
                }
                else
                {
                    Console.WriteLine("Wrong Value Try Again !");
                }

                count++;

                Console.WriteLine("Please enter a number between 1-10");
                g = int.Parse(Console.ReadLine());
                Guesses.Add(g);

            }

            Console.WriteLine("┌───── ----- ─────┐");
            Console.WriteLine("    - YOU WIN -");
            Console.WriteLine("└───── ----- ─────┘)");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < Guesses.Count; i++)
            {
                Console.WriteLine("Your guessed " + Guesses[i]);
            }

            Console.WriteLine("Amount of Guesses - " + Guesses.Count);
            
            Console.ReadLine();
        }
    }
}
