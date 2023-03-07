using System;

namespace Solution_22
{
    class Program
    {
        static void Main(string[] args)
        {//comment
            // Excersize 22
            // * 
            // * create a program that generates a random number between 1 and 10 
            // * and asks the user to guess the number and a message whether the 
            //* user's guess was too high or too low
            // * 
            // * gives a hint can create a random number generator with 
            // * Random  randomGenerator = new Random();
            // * int randomNumber =randomNumberGenerator.Next(min, max);
            // * you put in what values min and max you want as the range


            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            Console.WriteLine("What is the random number?");
            int userGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("The random number was {0}", randomNumber);

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Your answer is too low");


            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Your answer is too high");
            }

            else
            {
                Console.WriteLine("Your answer is Correct");
            }


            //make a do while loop on your own
            //the program will print a message to the user and will continue to print the message only if the user types again as a response

            string response; // will be outside of do while loop so it can be used as the while condition
            do
            {
                Console.WriteLine("Hello there");//will print out a message

                response = Console.ReadLine();  //will now wait for a user's response


            } while (response == "again");      //will  repeat only if they type in again in an indefinite amount of time
            //will stop if anything else is typed and entered
        }
    }
}
