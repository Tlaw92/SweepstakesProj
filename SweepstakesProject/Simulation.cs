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
        

        //Constructor
        public Simulation()
        {

        }


        //Methods

        public void CreateMarketingFirmWithManager(ISweepstakesManager manager)
        {
            MarketingFirm marketingFirm1 = new MarketingFirm(manager);
        }

    }
}
