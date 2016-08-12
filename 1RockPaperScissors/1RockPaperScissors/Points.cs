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

        public void points()
        {
            this.ss = 0;
            this.pp = 0;
            this.rr = 0;
            this.rp = 1;
            this.pr = 1;
            this.ps = 1;
            this.sp = 1;
            this.rs = 1;
            this.sr = 1;
        }

        public string playerOne()
        {
            this.pr += 1;
            this.sp += 1;
            this.rs += 1;
        }

        public string playerTwo()
        {
            this.rp += 1;
            this.ps += 1;
            this.sr += 1;
        }

    }
}
