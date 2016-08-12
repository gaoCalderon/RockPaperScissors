using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {

        string playerOne;
        string playerTwo;

        public void character(string playerOne, string playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        
          


        public void run()
        {

            Console.WriteLine("Weclome to Rock, Paper, Scissors");
            Console.WriteLine("Please create user 1:");
            this.playerOne = Console.ReadLine();
            Console.WriteLine("Create user two:");
            this.playerTwo = Console.ReadLine();
            Console.WriteLine("Welcome {0} & {1} [ENTER]", this.playerOne, this.playerTwo);
            Console.ReadLine();
            Console.WriteLine("GAME INSTRUCTIONS are:");
            Console.WriteLine("(r)Rock, (p)Paper, (s)Scissors [ENTER]");
            Console.ReadLine();
            RPS gameEntery = new RPS();
            Console.WriteLine("{0} first,", this.playerOne);
            gameEntery.rockPaperScissors();
            Console.WriteLine("{0} first,", this.playerTwo);
            gameEntery.rockPaperScissors();
            //gameEntery.score = Console.ReadLine() 

            Console.WriteLine("Round 2");
            Console.WriteLine("Do you want to continue playing? Type: Yes/No");


            string options = Console.ReadLine();
            if (options == "yes")
            {
                Console.WriteLine();
                gameEntery.rockPaperScissors();
            }

            else if (options == "no")
            {
                Console.WriteLine("Goodbye!");
            }

            Console.WriteLine("Round 3");
            Console.WriteLine("Do you want to continue playing? Type: Yes/No");


            string option = Console.ReadLine();
            if (option == "yes")
            {
                Console.WriteLine();
                gameEntery.rockPaperScissors();
            }

            else if (option == "no")
            {
                Console.WriteLine("Goodbye!");
            }

        }

    }


}
