using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RPS
    {

        public void rockPaperScissors()
        {
            bool continuePlay = true;
            while (continuePlay)
            {
                Console.WriteLine("Rock, Paper, Scissors");
                Console.WriteLine("Please Type in Entry");
                string userchoice = Console.ReadLine();
                if (userchoice == "rs")
                {
                    Console.WriteLine("Rock vs Scissors: Rock WINS");
                    continuePlay = false;
                }
                else if (userchoice == "sr")
                {
                    Console.WriteLine("Scissors vs Rock: Rock WINS");
                    continuePlay = false;
                }
                else if (userchoice == "rp")
                {
                    Console.WriteLine("Rock vs Paper: Paper WINS");
                    continuePlay = false;
                }
                else if (userchoice == "pr")
                {
                    Console.WriteLine("Paper vs Rock: Paper WINS");
                    continuePlay = false;
                }
                else if (userchoice == "sp")
                {
                    Console.WriteLine("Scissor vs Paper: Scissor WINS");
                    continuePlay = false;
                }
                else if (userchoice == "ps")
                {
                    Console.WriteLine("Paper vs Scissors: Scissors WINS");
                    continuePlay = false;
                }
                else if (userchoice == "rr")
                {
                    Console.WriteLine("Rock vs Rock: -TIE GAME- REMATCH");
                    continuePlay = true;
                }
                else if (userchoice == "pp")
                {
                    Console.WriteLine("Paper vs Paper: -TIE GAME- REMATCH");
                    continuePlay = true;
                }
                else if (userchoice == "ss")
                {
                    Console.WriteLine("Scissors vs Scissors: -TIE GAME- REMATCH");
                    continuePlay = true;
                }
                else
                {
                    Console.WriteLine("Not Valid Entry, Try Again.");
                    continuePlay = true;
                }



            }


        }
    }
}
