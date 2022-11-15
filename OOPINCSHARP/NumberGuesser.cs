using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPINCSHARP
{
    class NumberGueser
    {
        public Random random;
        public bool playAgain;
        public int min;
        public int max;
        public int guess;
        public int number;
        public int guesses;
        public string response;

        public NumberGueser()
        {
            random = new Random();
            playAgain = true;
            min = 1;
            max = 100;
            guess = 0;

}
        public static void Guess()
        {
            NumberGueser numObject = new NumberGueser();
            while (numObject.playAgain)
            {
                numObject.guess = 0;
                numObject.guesses = 0;
                numObject.number = numObject.random.Next(numObject.min, numObject.max + 1);
                numObject.response = "";

                while (numObject.guess != numObject.number)
                {
                    Console.WriteLine("Guess a Number between (" + numObject.min + " - " + numObject.max + ") : ");
                    numObject.guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + numObject.guess);

                    if (numObject.guess < 1)
                    {
                        Console.WriteLine("Please insert number greater than 1");
                    }
                    else if (numObject.guess > 100)
                    {
                        Console.WriteLine("Please insert number less than 100");
                    }

                    if (numObject.guess > numObject.number)
                    {
                        Console.WriteLine(numObject.guess + " is to high");
                    }
                    else if (numObject.guess < numObject.number)
                    {
                        Console.WriteLine(numObject.guess + " is to low!");
                    }
                    numObject.guesses++;
                }
                Console.WriteLine("Number:  " + numObject.number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + numObject.guesses);
                Console.WriteLine("Would you like to play again (Y/N: ");
                numObject.response = Console.ReadLine();
                numObject.response = numObject.response.ToUpper();

                if (numObject.response == "Y")
                {
                    numObject.playAgain = true;
                }
                else
                {
                    numObject.playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing! ... I guess");
            Console.WriteLine("Press Enter to Quit");
            Console.ReadKey();
        }
    }
    }
