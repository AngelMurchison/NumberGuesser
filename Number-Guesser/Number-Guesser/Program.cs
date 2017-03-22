using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guesser
{
    class Program
    {
        // Creating a tool for checking answers.
        static void makeAGuess(int myGuess, List<int> guesses)
        {
            int.TryParse(Console.ReadLine(), out myGuess);
            guesses.ForEach(n => Console.WriteLine($"\n{n}"));
            guesses.Insert(0, myGuess);
        }

        static void Main(string[] args)
        {
            // Making variables to store guesses, generating and storing a random number.
            int myGuess = 0;
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 100);
            List<int> guessedNumbers = new List<int> { };

            // Asking for and storing a guess.
            Console.WriteLine("I just generated a number between 1 and 100.. I'll give you 5 tries to guess it.");
            Console.WriteLine(RandomNumber);
            makeAGuess(myGuess, guessedNumbers);

            // Creating a loop to check the guess 5 times.
            for (int i = 0; i < 5; i++)
            {
                if (myGuess == RandomNumber)
                {
                    Console.WriteLine("Wow, aren't you the lucky one. Good job I guess. Press enter to go away.");
                    Console.ReadLine();
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("That was your fifth try, better luck next time stupid.");
                    Console.ReadLine();
                    break;
                }
                else if (myGuess < RandomNumber)
                {
                    Console.WriteLine("Sorry, your guess was lower than the number! Try again.");
                    makeAGuess(myGuess, guessedNumbers);
                }
                else if (myGuess > RandomNumber)
                {
                    Console.WriteLine("Sorry, your guess was higher than the number! Try again.");
                    makeAGuess(myGuess, guessedNumbers);
                }
            }
        }
    }
}
