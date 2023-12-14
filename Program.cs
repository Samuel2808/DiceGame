using System;
using static System.Console;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Clear();
            // Demos to do: 
            // - Random 
            // - If statemets 
            // - Switch statements

            //Random myRandomGenerator = new Random();    
            //int randomNumber = myRandomGenerator.Next(1, 7);
            //WriteLine($"A random number for you: {randomNumber}.");

            // == !=
            //> >= < <=
            //if (randomNumber == 1)
            //{
            //    WriteLine("You got a one - how lucky!");
            //}
            //else
            //{
            //    WriteLine("Dang - you didn't get a one this game");
            //}


            //if (randomnumber <= 3)
            //{
            //    writeline("you got a low roll");
            //}
            //else
            //{
            //    writeline("you got a high roll ");
            //}

            DiceGame game = new DiceGame();
            game.Start();


        }
    }
}