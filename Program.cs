using System;

namespace C__Learning_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            Console.WriteLine("Press Enter to roll 2 dies");
            while(roll != roll2){
                Console.ReadKey();

                int min = 1;
                
                //Change this to a higher number to make your chances lower
                int max = 7;

                roll = numberGen.Next(min, max);
                roll2 = numberGen.Next(min, max);

                Console.WriteLine("Roll 1: " + roll);
                Console.WriteLine("Roll 2: " + roll2);

                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll two of kind");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("--Press any key to exit--");

            Console.ReadKey();
        }
    }
}