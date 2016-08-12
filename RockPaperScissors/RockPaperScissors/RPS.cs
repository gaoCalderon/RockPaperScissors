using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RPS
    {

        char r;
        char p;
        char s;

        public void meaning(char rock, char paper, char scissors)
        {
            r = rock;
            p = paper;
            s = scissors;
        }

        public void score()
        {

        }
          

        public void rockPaperScissors()
        {
            bool continuePlay = true;
            while (continuePlay)
            {
                Game game = new Game();
                Console.WriteLine("Rock, Paper, Scissors");

                Console.WriteLine("Please Type in Entry");
                string userchoice = Console.ReadLine();
                if (userchoice == "r")
                {
                    Console.WriteLine();
                    continuePlay = false;
                }
                else if (userchoice == "s")
                {
                    Console.WriteLine();
                    continuePlay = false;
                }
                else if (userchoice == "p")
                {
                    Console.WriteLine();
                    continuePlay = false;
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
