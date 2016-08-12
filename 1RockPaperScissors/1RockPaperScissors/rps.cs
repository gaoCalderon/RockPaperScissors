using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class RPS
    {

        public void repeatGame()
        {
            Console.WriteLine("Do you want to continue playing? Type: Yes/No");
            string option = Console.ReadLine();
            if (option == "yes")
            {
                Console.WriteLine("Round {0}", this.round);
                rockPaperScissors();
            }

            else if (option == "no")
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Response");
                repeatGame();
            }


        public void rockPaperScissors()
        {
                Console.WriteLine("Rock, Paper, Scissors");
                Console.WriteLine("Please Type in Entry");
                Points points = new Points();
                string userchoice = Console.ReadLine();
                if (userchoice == "rs")
                {
                     Console.WriteLine("Rock vs Scissors: Rock WINS, {0} gets {1} point", );
                     points.playerTwo();
                }
                 else if (userchoice == "sr")
                {
                    Console.WriteLine("Scissors vs Rock: Rock WINS");
                    points.playerTwo();
                }
                else if (userchoice == "rp")
                {
                    Console.WriteLine("Rock vs Paper: Paper WINS");
                    points.playerOne();
                }
                else if (userchoice == "pr")
                {
                    Console.WriteLine("Paper vs Rock: Paper WINS");
                    points.playerOne();
                }
                else if (userchoice == "sp")
                {
                    Console.WriteLine("Scissor vs Paper: Scissor WINS");
                    points.playerOne();
                }
                else if (userchoice == "ps")
                {
                    Console.WriteLine("Paper vs Scissors: Scissors WINS");
                    points.playerTwo();
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
