﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();
            Game.run();
            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
