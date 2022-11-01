using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    public class Animal
    {
        //int ID;
        public float WaterAmt;
        public float Weight;
        public int age;
        public float DayCost;
        public string color;

        public float getWeight()
        {
            return Weight;
        }
        public float getWaterAmt()
        {
            return WaterAmt;
        }
        public Animal(float WaterAmt, float Weight,int age,float Daycost,string color)
        {
            //this.ID = ID;
            this.WaterAmt = WaterAmt;
            this.Weight = Weight;
            this.age=age;
            this.DayCost = Daycost;
            this.color = color;
        }

        public Animal() { }


        public virtual string getSpecies() { return "Generic"; }//to be overridden, gives spices
        public virtual double getProf(double[] prices) { return -1000; }// to be overridden, gives yearly profit
        public virtual double getMilk() { return 0; }// to be overridden, gives weekly milk produced
        public virtual string getDets()
        {
            return "Colour: "+color+"  Weight: "+Weight+"  Age: "+age+" Water consumption: "+WaterAmt+" Costs";
        }
        public double getCosts(double[] prices)
        {            
            double cost = DayCost - ((WaterAmt * 365) * prices[2]);
            return cost;
        }
        public virtual double getTax(double[] prices, int duration)// to be overridden, gives yearly tax
        {
            return 0;
        }

    }
}
