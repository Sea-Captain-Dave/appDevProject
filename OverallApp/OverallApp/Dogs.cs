using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    internal class Dogs : Animal
    {
        public Dogs(float DayCost , float WaterAmt, float Weight, int age,String clr)
            :base(WaterAmt,Weight,age, DayCost,clr)
        {            
        }
        public override string getSpecies()
        {
            return "Dog";
        }
        public override double getProf(double[] prices)
        {
            double prof = 0-DayCost;
            prof = prof - ((WaterAmt * 365) * prices[2]);
            return prof;
        }
    }
}
