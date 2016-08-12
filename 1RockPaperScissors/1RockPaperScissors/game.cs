using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Game
    {

        
        
        
        int round;
        int numberOfRounds;
        
       public void character(int round, int numberOfRounds)
        {
            
            this.round = 1;
            this.numberOfRounds = 3;
            
        }
        
                   

       public void run()
        {
                Points point = new Points();
                Console.WriteLine("Weclome to Rock, Paper, Scissors");
                Console.WriteLine("Please create user 1:");
                point.playerOne = Console.ReadLine();
                Console.WriteLine("Create user two:");
                point.playerOne = Console.ReadLine();
                Console.WriteLine("Welcome {0} & {1} [ENTER]", point.playerOne, point.playerTwo);
                Console.ReadLine();
                Console.WriteLine("GAME INSTRUCTIONS are:");
                Console.WriteLine("(r)Rock, (p)Paper, (s)Scissors");
                Console.WriteLine("both enteries must be submitted at one time [ENTER]");
                Console.ReadLine();
                Console.WriteLine("Examples are: rp, rs, pr, ps, sr, sp, rr, pp, ss");
                Console.WriteLine("Those are the only acceptable entrys. [ENTER]");
                Console.ReadLine();
                RPS gameEntery = new RPS();
                Console.WriteLine("{0} first, then {1} second", point.playerOne, point.playerTwo);
                gameEntery.rockPaperScissors();

            
            }

        

        }


    }
}
