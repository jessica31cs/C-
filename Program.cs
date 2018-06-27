using System;                       //bringing namespaces into this program

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jessica Coyotl";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}, let's play a game. Guess the number in 5 tries!!", input);

            int correctNum = 7;
            Console.WriteLine("guess a number");
            int guess = 0, tries = 0;
            while (guess != correctNum && tries++ < 5)
            {
                string temp = Console.ReadLine();
                try
                {
                    guess = Int32.Parse(temp);
                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input an integer!!!");
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine("Wrong, guess again: ");
            }
            if (tries < 5)
                Console.WriteLine("Yay, you guessed the number in {0} tries", tries);
            else
                Console.WriteLine("You didn't guess the number. It was {0}", correctNum);

            Console.ReadKey();
        }
    }
}
