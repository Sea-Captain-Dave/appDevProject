using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    internal class Cow : DairyAnimal
    {
        bool isJersy;
        public Cow(float WaterAmt, float Weight, int age, float Daycost, string color,float MilkAmount)
        :base(WaterAmt, Weight, age, Daycost, color,MilkAmount)
        {            
        }
        public override string getSpecies()
        {
            return "Cow";
        }
        public override double getTax(double[] prices, int duration)
        {
            double prof = (prices[4] * milkProduced * 54);
            return (prof * prices[3]);
        }
        public override double getProf(double[] prices)
        {
            double prof = (prices[5] * milkProduced * 54) ;
            prof = prof - (prof * prices[3]);
            prof = prof - this.DayCost;
            prof = prof - ((WaterAmt * 365) * prices[2]);
            return prof;
        }
        public override double getMilk() { return milkProduced; }


    }

}
