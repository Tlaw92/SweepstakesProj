using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        //variables
        private ISweepstakesManager _manager;


        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
            
        }

        //methods
        public void CreateSweepstake(string name)
        {
            //objective
            Sweepstakes sweepstakes = new Sweepstakes(name);


        }


    }
}
