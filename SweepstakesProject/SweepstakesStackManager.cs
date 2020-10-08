using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //variables
        private Stack<Sweepstakes> stack;

        //constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        //methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
            
        }
        //public Sweepstakes GetSweepstakes()
        //{

        //}
    }
}
