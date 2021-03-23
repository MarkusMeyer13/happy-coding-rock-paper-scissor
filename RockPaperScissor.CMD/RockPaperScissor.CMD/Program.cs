using System;
using System.Threading;

namespace RockPaperScissor.CMD
{
    class Program
    {
        private static readonly string paper = "Papier";
        private static readonly string scissor = "Schere";
        private static readonly string stone = "Stein";

        private static string[] thing =  { paper, stone, scissor};

        static void Main(string[] args)
        {
            string userSelection = string.Empty;
            if (args.Length == 0)
            {
                Console.WriteLine($"Bitte eingeben: '{paper}', '{scissor}' oder '{stone}'");
                userSelection = Console.ReadLine();
            }
            else
            {
                userSelection = args[0];
            }

            Random random = new Random();
            int randomIndex = random.Next(0, 2);
            //Console.WriteLine(randomIndex);

            var computerSelection = thing[randomIndex];

            Console.WriteLine("Computer: '" + computerSelection + "' User: '" + userSelection + "'");
            if (computerSelection == userSelection)
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (computerSelection == paper && userSelection== scissor)
            {
                Console.WriteLine("User gewinnt!");
            }
            else if (computerSelection == paper && userSelection == stone)
            {
                Console.WriteLine("Computer gewinnt!");
            }
            else if (computerSelection == scissor && userSelection == paper)
            {
                Console.WriteLine("Computer gewinnt!");
            }
            else if (computerSelection == scissor && userSelection == stone)
            {
                Console.WriteLine("User gewinnt!");
            }
            else if (computerSelection == stone && userSelection == scissor)
            {
                Console.WriteLine("Computer gewinnt!");
            }
            else if (computerSelection == stone && userSelection == paper)
            {
                Console.WriteLine("User gewinnt!");
            }
            else
            {
                Console.WriteLine("Computer sagt 'Nein'!");
            }

        }
    }
}
