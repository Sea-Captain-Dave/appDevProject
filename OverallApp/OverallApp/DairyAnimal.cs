using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    internal class DairyAnimal : Animal
    {
        public float milkProduced = 0;
        public DairyAnimal(float WaterAmt, float Weight, int age, float Daycost, string color,float MilkAmt)
            : base(WaterAmt, Weight, age, Daycost, color)
        {
            this.milkProduced = MilkAmt;
        }
        public override string getDets()
        {
            return "Colour: " + color + "  Weight: " + Weight + "  Age: " + age + " Water consumption: " + WaterAmt+" Milk Produced: "+milkProduced+" Profit: ";
        }
        public override double getMilk() { return milkProduced; }
    }
}

