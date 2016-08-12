using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RockPaperScissors
{
    class Points
    {
        int ss;
        int pp;
        int rr;
        int rp;
        int pr;
        int ps;
        int sp;
        int rs;
        int sr;

        public int pointScores()
        {
            this.ss = 0;
            this.pp = 0;
            this.rr = 0;
            this.rp = 0;
            this.pr = 0;
            this.ps = 0;
            this.sp = 0;
            this.rs = 0;
            this.sr = 0;
        }

        public void addOne()
        {
            this.rp += 1;
        }

    }
}
