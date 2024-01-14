using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int userGuess = int.Parse(Console.ReadLine());
        
         if (userGuess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (userGuess > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

         Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = -1;
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);


    }
}