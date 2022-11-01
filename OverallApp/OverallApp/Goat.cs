using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    internal class Goat:DairyAnimal
    {
        public Goat(float WaterAmt, float Weight, int age, float Daycost, string color, float MilkAmount)
: base(WaterAmt, Weight, age, Daycost, color, MilkAmount)
        {

        }
        public override string getSpecies()
        {
            return "Goat";
        }
        public override double getTax(double[] prices, int duration)
        {
            //gets the yearly tax
            double prof = (prices[0] * milkProduced * 54);
            return (prof * prices[3]);
        }
        public override double getProf(double[] prices)
        {
            //gats the yearly profit
            double prof = (prices[0] * milkProduced * 54);
            prof = prof - (prof * prices[3]);
            prof = prof  - this.DayCost;
            prof = prof - ((WaterAmt * 365) * prices[2]);            
            return prof;
        }
    }
}
