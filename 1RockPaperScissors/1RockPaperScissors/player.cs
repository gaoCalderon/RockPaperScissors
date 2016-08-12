using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Player
    {
        protected string name;
        protected int score;

        public Player(string Name)
        {
            this.name = Name;
            this.score = 0;
        }

        public void SetName()
        {
            Console.WriteLine("Pleas enter in a Player name [ENTER]");
            this.name = Console.ReadLine();
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetPlayerScore()
        {
            Console.WriteLine("{0} has {1} total points", name, score);
            return this.score;
        }
        public void addOne()
        {
            this.score += 1;
        }

    }

}
