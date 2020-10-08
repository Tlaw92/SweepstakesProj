using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesQueueManager thing = new SweepstakesQueueManager();
            SweepstakesStackManager thing2 = new SweepstakesStackManager();

            MarketingFirm myFirm = new MarketingFirm(thing2);



            Simulation sim1 = new Simulation();
            sim1.RunMain();
        }
        
    }
}
