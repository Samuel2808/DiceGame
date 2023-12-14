using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DiceGame
{
    internal class DiceGame
    {
        private string GameName;
        private int Score;
        private Random RandomGenerator;
        private string UnknowRollGraphic = @"---------
|?     ?|
|?  ?  ?|
|?     ?|
---------";
        private string UnknowRoll2Graphic = @"-----
|   |
| o |
|   |
-----";

private string UnknowRoll3Graphic = @"-----
| o |
|   |
| o |
-----";

private string UnknowRoll4Graphic = @"-----
| o |
| o |
| o |
-----";

private string UnknowRoll5Graphic = @"-----
| o o |
|     |
| o o |
-----";

private string UnknowRoll6Graphic = @"-----
| o o |
|  o  |
| o o |
-----";

private string UnknowRoll7Graphic = @"-----
| o o |
| o o |
| o o |
-----";
        public DiceGame()
        {
            Score = 0;
            // Initialize anything that we need to:
            GameName = "Rolls Game";
            RandomGenerator = new Random();
        }

        public void Start()
        {
            //Method that starts the game running.
            Title = GameName;
            WriteLine($" === {GameName} === ");
            WriteLine($"{UnknowRollGraphic}");
            WriteLine("\nLet's play a game of chance with dice");
            WriteLine("\n====Guide to play====");
            WriteLine("\t> I'll role the dice each round");
            WriteLine("\t> U have to guess if it's high or low");
            WriteLine("\t> If u get the correct answer, I'll  give u a point");
            WriteLine("\nReady to play - yes or no?\n");

            string playResponse = ReadLine().Trim().ToLower();
            Clear();
            if (playResponse == "yes")
            {
                WriteLine("Bien - Let't play bruh");
                PlayRound();
            }
            else  
            {
                WriteLine("Don't worry - We can play in another time.");
            }
            
            WriteLine("\nPress any key to exit...");
            ReadKey();
        }

        private void PlayRound()
        {
            // Method that runs one round of rolling and guessing.
            Clear();
            WriteLine("\nI'm about to roll");
            WriteLine($"{UnknowRollGraphic}");
            WriteLine("\nIs it going to be low (1, 2, 3) or high (4, 5, 6)");
            string response = ReadLine().Trim().ToLower();
            Clear();
            WriteLine($"u guessed {response}");
            
            int roll = RandomGenerator.Next(1, 7);
            ForegroundColor = ConsoleColor.Magenta;
            switch (roll)
                
            {
                case 1:
                    WriteLine(UnknowRoll2Graphic);
                    break;
                case 2:
                    WriteLine(UnknowRoll3Graphic);
                    break;
                case 3:
                    WriteLine(UnknowRoll4Graphic);
                    break;
                case 4:
                    WriteLine(UnknowRoll5Graphic);
                    break;
                case 5:
                    WriteLine(UnknowRoll6Graphic);
                    break;
                case 6:
                    WriteLine(UnknowRoll7Graphic);
                    break;
                default:
                    WriteLine("Uh oh... the roll broke...");
                    break;
            }
            ForegroundColor = ConsoleColor.Blue;
            if (response == "high")
            {
                WriteLine("\nu are high, sooooo...");
                if (roll <= 3)
                {
                    Lose();
                }
                else
                {
                    Win();
                }
            }
            else if (response == "low")
            {
                WriteLine("\nu are low, sooooo...");
                if (roll <= 3)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
            }
            else
            {
                WriteLine($"\nU guessed '{response}' . Thats not valid. Try again");
            }

            PlayAgain();
            Clear();
        }

        private void Win()
        {
            //Method that increments the score and lets the player know they won.
            Score = Score + 1;
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\nu win.");
            WriteLine($"\t> ur score: {Score}");
        }
        private void Lose()
        {
            //Methods  that lets the player know they lost.
            ForegroundColor = ConsoleColor.Red;
            WriteLine("u lose.");
            WriteLine($"\t>ur score: {Score}");
        }

        private void PlayAgain()
        {
            //method that ask the player if they want to play again.
            ForegroundColor = ConsoleColor.Blue;
            Write("would u like to play again ? (yes or no).");

            
            string playResponse = ReadLine().Trim().ToLower();
           

            if (playResponse == "yes")
            {
                PlayRound();
            }
            else 
            { 
                WriteLine("well, thaks for play. See u in the next game...");

            }

           

        }
            
    }
}


