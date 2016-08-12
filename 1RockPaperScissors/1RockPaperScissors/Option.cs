using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Option
    { 
    
        public void rockPaperScissors()
        {
            Console.WriteLine("Rock, Paper, Scissors");
            Console.WriteLine("Please Type in an Entry");
            Game game = new Game();
            Player person = new Player();
            string userchoice = Console.ReadLine();
            if (userchoice == "rs")
            {
                Console.WriteLine("Rock vs Scissors: Rock WINS, {0} gets 1 point", game.gamerTwo);
                game.PlayTwoGetScore();
            }
            else if (userchoice == "sr")
            {
                Console.WriteLine("Scissors vs Rock: Rock WINS, {0} gets 1 point", game.gamerTwo);
                game.PlayTwoGetScore();
            }
            else if (userchoice == "rp")
            {
                Console.WriteLine("Rock vs Paper: Paper WINS, {0} gets 1 point", game.gamerOne);
                game.PlayOneGetScore();
            }
            else if (userchoice == "pr")
            {
                Console.WriteLine("Paper vs Rock: Paper WINS, {0} gets 1 point", game.gamerOne);
                game.PlayOneGetScore();
            }
            else if (userchoice == "sp")
            {
                Console.WriteLine("Scissor vs Paper: Scissor WINS, {0} gets 1 point", game.gamerOne);
                game.PlayOneGetScore();
            }
            else if (userchoice == "ps")
            {
                Console.WriteLine("Paper vs Scissors: Scissors WINS, {0} gets 1 point", game.gamerTwo);
                game.PlayTwoGetScore();
            }
            else if (userchoice == "rr")
            {
                Console.WriteLine("Rock vs Rock: -TIE GAME- REMATCH");
                rockPaperScissors();
            }
            else if (userchoice == "pp")
            {
                Console.WriteLine("Paper vs Paper: -TIE GAME- REMATCH");
                rockPaperScissors();
            }
            else if (userchoice == "ss")
            {
                Console.WriteLine("Scissors vs Scissors: -TIE GAME- REMATCH");
                rockPaperScissors();
            }
            else
            {
                Console.WriteLine("Not Valid Entry, Try Again.");
                rockPaperScissors();
            }
        }
    }
}
