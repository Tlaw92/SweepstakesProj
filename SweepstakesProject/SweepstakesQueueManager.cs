using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //variables
        private Queue<Sweepstakes> queue;

        //constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        //methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }


        //public Sweepstakes GetSweepstakes()
        //{

        //}
    }
}
