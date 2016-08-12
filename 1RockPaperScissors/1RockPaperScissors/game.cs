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
        }

        public Player createPlayer()
    {
        Player gamePlayer = new Player();
        gamePlayer.SetName();
        return gamePlayer;
    }

    public int PlayOneGetScore()
    {
        Player person = new Player();
        person.addOne();
        Console.WriteLine("{0} has {1} total points", this.gamerOne.getName, person.GetPlayerScore());
    }

    public int PlayTwoGetScore()
    {
        Player person = new Player();
        person.addOne();
        Console.WriteLine("{0} has {1} total points", this.gamerTwo.getName, person.GetPlayerScore());
    }


    public void run()
        {
            Player person = new Player();
            Console.WriteLine("Weclome to Rock, Paper, Scissors");
            Console.WriteLine("1st Player");
            createPlayer.gamerOne();
            Console.WriteLine("2nd Player");
            createPlayer.gamerTwo();
            Console.WriteLine("Welcome {0} & {1} [ENTER]", this.gamerOne.GetName, this.gamerTwo.GetName());
            Console.ReadLine();
            Console.WriteLine("GAME INSTRUCTIONS are:");
            Console.WriteLine("(r)Rock, (p)Paper, (s)Scissors");
            Console.WriteLine("both enteries must be submitted at one time [ENTER]");
            Console.ReadLine();
            Console.WriteLine("Examples are: rp, rs, pr, ps, sr, sp, rr, pp, ss");
            Console.WriteLine("Those are the only acceptable entrys. [ENTER]");
            Console.ReadLine();
            Console.WriteLine("{0} first, then {1} second", this.gamerOne.GetName, this.gamerTwo.GetName());
            Repeat repeatGame = new Repeat();
            repeatGame.repeatTheGame();
        }
        
    }
}
