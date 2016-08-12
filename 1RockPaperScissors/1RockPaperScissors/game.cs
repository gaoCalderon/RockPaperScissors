using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Game
    {

        public string gamerOne;
       public  string gamerTwo;

        public void character(string gamerOne, string gamerTwo)
        {
            this.gamerOne = gamerOne;
            this.gamerTwo = gamerTwo;
        }

        public void run()
        {
            Points point = new Points();
            Console.WriteLine("Weclome to Rock, Paper, Scissors");
            Console.WriteLine("Please create user 1:");
            this.gamerOne = Console.ReadLine();
            Console.WriteLine("Create user two:");
            this.gamerTwo = Console.ReadLine();
            Console.WriteLine("Welcome {0} & {1} [ENTER]", this.gamerOne, this.gamerTwo);
            Console.ReadLine();
            Console.WriteLine("GAME INSTRUCTIONS are:");
            Console.WriteLine("(r)Rock, (p)Paper, (s)Scissors");
            Console.WriteLine("both enteries must be submitted at one time [ENTER]");
            Console.ReadLine();
            Console.WriteLine("Examples are: rp, rs, pr, ps, sr, sp, rr, pp, ss");
            Console.WriteLine("Those are the only acceptable entrys. [ENTER]");
            Console.ReadLine();
            Console.WriteLine("{0} first, then {1} second", this.gamerOne, this.gamerTwo);
            Repeat repeatGame = new Repeat();
            repeatGame.repeatTheGame();
        }
        
    }
}
