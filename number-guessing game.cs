using System;
using System.Collections.Generic;
using System.Text;

namespace SmallProjects
{
    internal class number_guessing_game
    {
        static void Main(string[] args)
        {
            Random random=new Random();
            bool playAgain = true;
            string response;
            int min;
            int max ;
            int guess;
            int number;
            int guesses;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                min = 1;
                max = 100;
                response = "";
                number=random.Next(min,max+1);

                while(guess!=number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + " : ");
                    guess=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: "+ guess);

                    if(guess>number)
                    {
                        Console.WriteLine(guess + " is too high!");
                        max= guess;
                    }
                    else if(guess<number)
                    {
                        Console.WriteLine(guess + " is too low!");
                        min= guess;

                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Would you like to play again(Y/N): ");
                response= Console.ReadLine();
                response= response.ToUpper();

                if(response=="Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain= false;
                }
            }
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

        }
    }
}
