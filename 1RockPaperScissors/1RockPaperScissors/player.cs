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

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }

        public void SetName()
        {
            Console.WriteLine("Please enter name:");
            this.name = Console.ReadLine();
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetPlayerScore()
        {
            return this.score;
        }
        public void addOne()
        {
            this.score += 1;
        }

    }

}
