using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubExperiment
{
    public class Policy
    {
        public int Id { get; set; }
        public int Premium { get; set; }

        public Policy(int id)
        {
            this.Id = id;
        }


        public void CalcPremium(int units, int costPerUnit)
        {
            this.Premium = units * costPerUnit;
        }
    }
}
