using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Game
    {

        public Player gamerOne;
        public Player gamerTwo;
        int round;
        int numberOfRounds;

        public void turns(int round, int numberOfRounds)
        {
            this.round = 1;
            this.numberOfRounds = 3;
        }

        public void run()
        {
            Console.WriteLine("Weclome to Rock, Paper, Scissors");
            Console.WriteLine("1st Player, Pleas enter in a Player name [ENTER]");
            gamerOne = new Player(Console.ReadLine());
            Console.WriteLine("2nd Player, Pleas enter in a Player name [ENTER]");
            gamerTwo = new Player(Console.ReadLine());
            Console.WriteLine("Welcome {0} & {1} [ENTER]", gamerOne.GetName(), gamerTwo.GetName());
            Console.ReadLine();
            Console.WriteLine("GAME INSTRUCTIONS are:");
            Console.WriteLine("(r)Rock, (p)Paper, (s)Scissors");
            Console.WriteLine("both enteries must be submitted at one time [ENTER]");
            Console.ReadLine();
            Console.WriteLine("Examples are: rp, rs, pr, ps, sr, sp, rr, pp, ss");
            Console.WriteLine("Those are the only acceptable entrys. [ENTER]");
            Console.ReadLine();
            Console.WriteLine("{0} first, then {1} second", gamerOne.GetName(), gamerTwo.GetName());
            Repeat repeatGame = new Repeat();
            Option enterGame = new Option();
            repeatTheGame();
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
    