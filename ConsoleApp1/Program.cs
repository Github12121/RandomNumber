using System;

class Guess
{
    public static void Game()
    {
        const int Turns = 5;
        const int MaxNumber = 100;
        int[] fooKeepsTrackOfGuesses = new int [Turns];
        
            var rnd = new Random();
        int actualNumber = rnd.Next(1, MaxNumber + 1);
        string input;
        var number = 0;
        int currentTurn = 0;
        
        do
        {
           
            Console.WriteLine("I'm thinking of a number between 1 and " + MaxNumber);

            bool parseSuccess;
            do 
            {
                input = Console.ReadLine();

                parseSuccess = int.TryParse(input, out number);

                if (!parseSuccess)
                {
                    Console.WriteLine("Please Try Again!");
                }

                
            } while (!parseSuccess);
 
            number = Convert.ToInt32(input);
            fooKeepsTrackOfGuesses[currentTurn] = number;


            if (number > actualNumber)
            {
                Console.WriteLine("The number is smaller");
            }
            else if (number < actualNumber)
            {
                Console.WriteLine("The number is bigger");
            }
            currentTurn = currentTurn + 1;
        }
        while (number != actualNumber && currentTurn < Turns);

        if (number == actualNumber)
        {
            Console.WriteLine("You Won");
            Console.WriteLine("You Took " + currentTurn + " Turns");
        }
        else
        {
            Console.WriteLine("That was very sad");

        }
        foreach (int i in fooKeepsTrackOfGuesses)
        {
            Console.WriteLine(i);
        }
    }

    public static void Main(string[] args)
    {
        
        string input;
        
        do
        {
            Game();

            Console.WriteLine("Do you want to play again?");

            input = Console.ReadLine();

        }
        while ("y" == input);

               
    }
}