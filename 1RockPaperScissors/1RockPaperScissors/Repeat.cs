using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Repeat
    {

        int round;
        int numberOfRounds;

        public void turns(int round, int numberOfRounds)
        {
            this.round = 1;
            this.numberOfRounds = 3;
        }



        public void repeatTheGame()
        {
            while (this.round < this.numberOfRounds)
            {
                Console.WriteLine("Do you want to continue playing? Type: Yes/No");
                Option gameEntery = new Option();
                string option = Console.ReadLine();
                if (option == "yes")
                {
                    Console.WriteLine("Round {0}", this.round);
                    gameEntery.rockPaperScissors();
                }

                else if (option == "no")
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Response");
                    repeatTheGame();
                }
            }
        }
    }
}
