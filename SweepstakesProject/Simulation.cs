using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {

        //variables
        public Contestant contestant1;
        public Contestant contestant2;
        public Sweepstakes sweepstakes1;

        //Constructor
        public Simulation()
        {

        }


        //Methods
        public void RunMain()
        {
            sweepstakes1 = new Sweepstakes("October Sweep");
            contestant1 = new Contestant("Jim", "Baron", "JimBaron@gmail.com", sweepstakes1.GetRandomNumber(50));
            contestant2 = new Contestant("Tim", "Burton", "TimBurton@gmail.com", sweepstakes1.GetRandomNumber(50));

            sweepstakes1.RegisterContestant(contestant1);
            sweepstakes1.RegisterContestant(contestant2);
            Console.ReadLine();
        }

    }
}
