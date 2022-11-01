using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    internal class Sheep : Animal
    {
        public float woolProd;
        public  Sheep(float WaterAmt, float Weight, int age, float Daycost, string color,float woolProduced)
            :base(WaterAmt,Weight,age,Daycost,color)
        {
            this.woolProd = woolProduced;
        }
        public override string getSpecies()
        {
            return "Sheep";
        }
        public override double getTax(double[] prices, int duration)
        {
            double prof = (prices[1] * woolProd* 54);
            return (prof * prices[3]);
        }
        public override double getProf(double[] prices)
        {
            double prof = (prices[1] * woolProd * 54);
            prof = prof - (prof * prices[3]);
            prof = prof - this.DayCost;
            prof = prof - ((WaterAmt * 365) * prices[2]); 
            return prof;           
        }
        public override double getMilk() { return woolProd; }
        public override string getDets()
        {
            return "Colour: " + color + "  Weight: " + Weight + "  Age: " + age + " Water consumption: " + WaterAmt+" Wool Produced: "+woolProd+" Profit: ";
        }
    }
}
