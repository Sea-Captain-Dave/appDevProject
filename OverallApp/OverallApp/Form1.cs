using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace OverallApp
{
    public partial class Form1 : Form
    {
        static Dictionary<int, Animal> animalsStorage = new Dictionary<int, Animal>();
        //Stores all animals
        public double[] Costs = new double[6];
        //Stores prices/taxes
        public void AddToDictionary()
        {
            string connectionString = "";
            OleDbConnection conn = null;
            try
            {
                connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                    Data Source = C:\\Users\\lands\\FarmInfomation.accdb;
                                    Persist Security Info = False";  //Targets the file
                conn = new OleDbConnection(connectionString); //establishes the connection
            }
            catch
            {
                outBox1.Text += ("failed to creat connection \r\n");
            }
            string CommandBuilder = "";
            try
            {
                conn.Open();//opens the connection
            }
            // Dogs
            // Dogs
            catch { outBox1.Text += ("Failed to Open connection\r\n"); }
            CommandBuilder = "Select * from [" + "Dogs" + "];";
            OleDbCommand cmd = new OleDbCommand(CommandBuilder, conn);
            try
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {//(float DayCost , float WaterAmt, float Weight, int age,String clr)
                        try
                        {
                            Dogs Temp = new Dogs(
                                float.Parse(reader[reader.GetName(5).ToString()].ToString()),//daycost
                                float.Parse(reader[reader.GetName(1).ToString()].ToString()),//water
                                float.Parse(reader[reader.GetName(2).ToString()].ToString()),//weight
                                int.Parse(reader[reader.GetName(3).ToString()].ToString()),//age
                                reader[reader.GetName(4).ToString()].ToString());//colour

                            animalsStorage.Add(int.Parse(reader[reader.GetName(0).ToString()].ToString()), Temp);
                        }
                        catch { outBox1.Text += "Failed to import a dog\r\n"; }
                    }
                }
            }
            catch { outBox1.Text += "Failed to import dog table\r\n"; }
            // Sheep
            // Sheep
            CommandBuilder = "Select * from [" + "Sheep" + "];";
            cmd = new OleDbCommand(CommandBuilder, conn);
            try
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        //float WaterAmt, float Weight, int age, float Daycost, string color,float woolProduced
                        //String str1 = "Sheep";
                        try
                        {
                            Sheep Temp = new Sheep(
                                float.Parse(reader[reader.GetName(1).ToString()].ToString()), //water
                                float.Parse(reader[reader.GetName(3).ToString()].ToString()), //weight
                                int.Parse(reader[reader.GetName(4).ToString()].ToString()), //age
                                float.Parse(reader[reader.GetName(2).ToString()].ToString()),  //Daycost
                                reader[reader.GetName(5).ToString()].ToString(),                //colour
                                float.Parse(reader[reader.GetName(6).ToString()].ToString()));//wool
                            int id = int.Parse(reader["ID"].ToString());
                            if (errorCheck(Temp))
                            {
                                animalsStorage.Add(id, Temp);
                            }
                            else { outBox1.Text += "Some of a sheeps details were invalid \r\n"; }                            
                        }
                        catch { outBox1.Text += "Failed to import a sheep\r\n"; }
                    }
                }
            }
            catch { outBox1.Text += "failed to import sheep table\r\n"; }
            //Cows
            //Cows
            CommandBuilder = "Select * from [" + "Cows" + "];";
            cmd = new OleDbCommand(CommandBuilder, conn);
            try
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Animal Temp = new Animal();
                        //float WaterAmt, float Weight, int age, float Daycost, string color,float MilkAmount
                        try
                        {
                            if (bool.Parse(reader[reader.GetName(7).ToString()].ToString())) {
                                Temp = new Jcow(
                                    float.Parse(reader[reader.GetName(1).ToString()].ToString()),//water
                                    float.Parse(reader[reader.GetName(3).ToString()].ToString()), //weight
                                    int.Parse(reader[reader.GetName(4).ToString()].ToString()),  //age
                                    float.Parse(reader[reader.GetName(2).ToString()].ToString()),//daycost
                                    reader[reader.GetName(5).ToString()].ToString(),//colour
                                    float.Parse(reader[reader.GetName(6).ToString()].ToString())//milk
                                    );
                            }
                            else
                            {
                                Temp = new Cow(
                                float.Parse(reader[reader.GetName(1).ToString()].ToString()),//water
                                float.Parse(reader[reader.GetName(3).ToString()].ToString()), //weight
                                int.Parse(reader[reader.GetName(4).ToString()].ToString()),  //age
                                float.Parse(reader[reader.GetName(2).ToString()].ToString()),//daycost
                                reader[reader.GetName(5).ToString()].ToString(),//colour
                                float.Parse(reader[reader.GetName(6).ToString()].ToString())//milk
                                    );
                            }
                            int id = int.Parse(reader["ID"].ToString());
                            if (errorCheck(Temp))
                            {
                                animalsStorage.Add(id, Temp);
                            }
                            else { outBox1.Text += "Some of a Cow details were invalid\r\n"; }
                        }
                        catch { outBox1.Text += "Failed to import a Cow\r\n"; }
                    }
                }
            }
            catch { outBox1.Text += "failed to import cow table \r\n"; }
            // Goats
            //Goats
            CommandBuilder = "Select * from [" + "Goats" + "];";
            cmd = new OleDbCommand(CommandBuilder, conn);
            try
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            //float WaterAmt, float Weight, int age, float Daycost, string color, float MilkAmount
                            Goat Temp = new Goat(
                            float.Parse(reader[reader.GetName(1).ToString()].ToString()),//water
                            float.Parse(reader[reader.GetName(3).ToString()].ToString()),//weight
                            int.Parse(reader[reader.GetName(4).ToString()].ToString()),//age
                            float.Parse(reader[reader.GetName(2).ToString()].ToString()),//daycost
                            reader[reader.GetName(5).ToString()].ToString(),//colour
                            float.Parse(reader[reader.GetName(6).ToString()].ToString()));//milkProd
                            int id = int.Parse(reader["ID"].ToString());
                            if (errorCheck(Temp))
                            {
                                animalsStorage.Add(id, Temp);
                            }
                            else { outBox1.Text += "Some of a goats details were invalid\r\n"; }
                        } catch { outBox1.Text += "failed to import a goat\r\n"; }
                    }
                }
            }
            catch { outBox1.Text += "failed to import goats table\r\n"; }
            CommandBuilder = "Select * from [" + "Commodity_Prices" + "];";
            cmd = new OleDbCommand(CommandBuilder, conn);
            try
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    int counter = 0;
                    while (reader.Read())
                    {
                        try
                        {
                            double temp = double.Parse(reader[reader.GetName(1).ToString()].ToString());
                            Costs[counter] = temp;
                        }
                        catch
                        {
                            outBox1.Text += "Failed to import " + reader[reader.GetName(0).ToString()] + " data exists but not in correct format, startup failed";
                            //Application needs pricing data to work, should terminate without it
                            button1.Visible = false;
                            comboBox1.Visible = false;
                            searchBox.Visible = false;
                            dumpDBbutton.Visible = false;
                            Costs[counter] = 0;
                        }
                        counter++;
                    }
                }
            }
            catch
            {
                //without commodity prices table core functionality is entirely broken so
                //terminating the application is best
                outBox1.Text += "Failed to import commodity prices table, Startup failed";
                button1.Visible = false;
                comboBox1.Visible = false;
                searchBox.Visible = false;
                dumpDBbutton.Visible = false;
            }
            conn.Close();//database is no longer needed
            if (animalsStorage.Count < 1)
            {
                // without animals core functionality is non-existat so terminating the app is best.
                outBox1.Text += "failed to import any animals, Startup failed";
                button1.Visible = false;
                comboBox1.Visible = false;
                searchBox.Visible = false;
                dumpDBbutton.Visible = false;
                // if only some animale/tables of animals fail to import then the application can still work.
            }
        }
        private string printTreeDecending(BST tree)
        {
            //used to get a string of all animals in decending order
            string multiAniDets = "";
            if (tree == null)
            {
                return "";
            }
            multiAniDets += printTreeDecending(tree.getright());
            foreach (int ID in tree.IDs)
            {
                multiAniDets += returnAnimalDets(ID, animalsStorage[ID]);
            }
            multiAniDets += printTreeDecending(tree.getleft());
            return multiAniDets;
        }
        public void PrintProfDec(Dictionary<int, Animal> temp)
        {
            //converts the given dictionary into a BST for the printtreedecending method
            BST theTree = new BST();
            foreach (KeyValuePair<int, Animal> pair in temp)
            {
                theTree.addToTree(pair.Value, pair.Value.getProf(Costs), pair.Key);
            }
            outBox1.Text = printTreeDecending(theTree);
        }
        public void displaySpecies(String species)
        {
            outBox1.Text = "";
            //Stack<Animal> temp = new Stack<Animal>();
            Dictionary<int, Animal> temp = new Dictionary<int, Animal>();
            foreach (KeyValuePair<int, Animal> got in animalsStorage) {
                if (got.Value.getSpecies().ToLower() == species)
                {
                    //OutputAnimal(got.Key,got.Value);
                    temp.Add(got.Key, got.Value);
                }
            }
            PrintProfDec(temp);
        }
        public string returnAnimalDets(int ID, Animal ani)
        {
            //returns a string of an animals details
            String animalDets = "Species: " + ani.getSpecies() + "  ID: " + ID + " " + ani.getDets() + ani.getProf(Costs) + "\r\n";
            return animalDets;
        }

        private bool errorCheck(Animal ani)
        {
            //checks for errors in valid table data;
            if(ani == null) { return false; }
            if (ani.age < 0 || ani.Weight <= 0 || ani.WaterAmt <= 0 || ani.getMilk() < 0) { return false; }
            return true;
        }
        public Form1()
        {
            InitializeComponent();
            AddToDictionary();
            //displayItem(3001);
            auxSearch.Visible = false;
            AuxButton.Visible = false;
            auxBoxLable.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // prints an animal corrosponding to the ID (if present)
            try { 
                int ID = int.Parse(searchBox.Text);
                outBox1.Text = returnAnimalDets(ID, animalsStorage[ID]);
                }
            catch { outBox1.Text = "Not a valid animal"; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxSearch.Visible = false;
            AuxButton.Visible = false;
            auxBoxLable.Visible = false;
            // ^^ hides the search by age stuff.
            // This is the dropdown menue.
            if (comboBox1.SelectedIndex == 0)
            {
                displaySpecies("goat");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                displaySpecies("sheep");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                displaySpecies("cow");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                displaySpecies("jearsy cow");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                displaySpecies("dog");
            }
            if (comboBox1.SelectedIndex == 5)
            {
                //displays the total profitability of all animals.
                double totalProf = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    totalProf += thisAni.Value.getProf(Costs);
                }
                outBox1.Text = "The total daily profitability of all animals on the farm each day is: " + (totalProf/365).ToString();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                //displays the total milk produced
                double totalMilk = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    if (thisAni.Value.getSpecies() == "Dog" || thisAni.Value.getSpecies() == "Sheep")
                    {}
                    else
                    {
                        totalMilk += thisAni.Value.getMilk();
                    }
                }
                outBox1.Text = "The total milk produced by the farm each week is: " + totalMilk.ToString();
            }
            if (comboBox1.SelectedIndex == 7)
            {
                //ratio by age
                outBox1.Text = "";
                auxSearch.Text = "";
                auxSearch.Visible = true;
                AuxButton.Visible = true;
                auxBoxLable.Visible = true;
                auxBoxLable.Text = "Enter age";
            }
            if (comboBox1.SelectedIndex == 8)
            {
                // avg age
                int totalAge = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    if(thisAni.Value.getSpecies() != "Dog")
                    totalAge += thisAni.Value.age;
                }
                double avgAge = totalAge / (double)animalsStorage.Count;
                outBox1.Text = "average Age = " + avgAge;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                //compaire the avridge profit of all milk producers vs wool producers
                double totalMilk = 0;
                double totalWool = 0;
                int dairyCounter = 0;
                int woolCounter = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    if (thisAni.Value.getSpecies() == "Dog")
                    {

                    }
                    else if (thisAni.Value.getSpecies() == "Sheep")
                    {
                        totalWool += thisAni.Value.getProf(Costs);
                        woolCounter++;
                    }
                    else
                    {
                        totalMilk += thisAni.Value.getProf(Costs);
                        dairyCounter++;
                    }
                    double woolAvg = totalWool / woolCounter;
                    double milkAvg = totalMilk / dairyCounter;

                    outBox1.Text = " wool avg profit " + woolAvg + " dairy Avg profit " + milkAvg+" each year";
                }
            }
            if (comboBox1.SelectedIndex == 10)
            {
                // dispalys the ratio of red animals vs non red animals
                outBox1.Text = "";
                double counter = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {

                    if (thisAni.Value.color.ToLower() == "red")
                    {

                        counter++;
                    }
                    
                    
                }
                double nonreds = animalsStorage.Count() - counter;
                if(counter == 0)
                {
                    outBox1.Text = "There are no red animals";
                }
                else
                {
                    if(nonreds == 0)
                    {
                        outBox1.Text = "All animals are red";
                    }else
                    {
                        outBox1.Text = "for each red animal there are " + nonreds/counter + " non red animals";
                    }
                }
                
            }
            if (comboBox1.SelectedIndex == 11)
            {
                // displays the total tax paid on Jearsy cows
                double totalJcowTax = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    if (thisAni.Value.getSpecies() == "Jearsy Cow")
                    {
                        totalJcowTax += thisAni.Value.getTax(Costs, 0);
                    }
                }
                outBox1.Text = "Total tax for jearsy cows is " +(totalJcowTax/12)+"each month";
            }
            if (comboBox1.SelectedIndex == 12)
            {
                // Displays the total tax of all animals
                double totalTax = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    totalTax += thisAni.Value.getTax(Costs, 0);
                }
                outBox1.Text = "Total tax is " + (totalTax/12)+" each month";
            }
            if (comboBox1.SelectedIndex == 13)
            {
                //displays the profit or losses of all Jearsy cown
                double totalJcowProfit = 0;
                foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    if (thisAni.Value.getSpecies() == "Jearsy Cow")
                    {
                        totalJcowProfit += thisAni.Value.getProf(Costs);
                    }
                }
                outBox1.Text = "Total profit for jearsy cows is " + totalJcowProfit+" each year";
            }
            if(comboBox1.SelectedIndex == 14)
            {
                //Dog to non dog ratio comparison
                double dogCosts = 0;
                double nonDogCosts = 0;
                foreach(KeyValuePair<int, Animal> thisAni in animalsStorage)
                {
                    if(thisAni.Value.getSpecies() != "Dog")
                    {
                        nonDogCosts += thisAni.Value.getCosts(Costs);
                    }
                    else
                    {
                        dogCosts += thisAni.Value.getCosts(Costs);
                    }
                }
                if(dogCosts >= 0)
                {
                    outBox1.Text = "There are no dogs";
                }
                else
                {
                    if(nonDogCosts >= 0)
                    {
                        outBox1.Text = "there are only dogs";
                    }
                    else
                    {
                        nonDogCosts = nonDogCosts / dogCosts;
                        dogCosts = 1;
                        outBox1.Text = "the ratio of yearly dog cost compaired to other costs is " + dogCosts
                            + " doller spent on dogs for every " + nonDogCosts + " spent on not dogs";
                    }
                } 
            }
        }
        private void outBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AuxButton_Click(object sender, EventArgs e)
        {
            //this button handles the age search.
            double age = 0;
            try
            {
                age = double.Parse(auxSearch.Text);
            } catch { outBox1.Text = "Not a number"; return; }
            int lessAgeCounter = 0;
            double greaterAgeCounter = 0;
            foreach (KeyValuePair<int, Animal> thisAni in animalsStorage)
            {
                if (thisAni.Value.age > age)
                {
                    greaterAgeCounter++;
                }
                else
                {
                    lessAgeCounter++;
                }
            }
            if(greaterAgeCounter == 0)
            {
                outBox1.Text = "there are no animals older than that";
            }
            else
            {
                if(lessAgeCounter == 0)
                {
                    outBox1.Text = "there are no animals that age or less";
                }
                else
                {
                    outBox1.Text = "for each animal " + age + " years old there are " + (greaterAgeCounter / lessAgeCounter) + " older animals";
                }
            }            
        }
        private static string getIDDec(BST tree)
        {
            if(tree == null) { return ""; }
            string IDDec = "";
            IDDec += getIDDec(tree.right);
            foreach(int i in tree.IDs)
            {
                IDDec += i.ToString()+ "\r\n";
            }
            IDDec += getIDDec(tree.left);
            return IDDec;
        }
        private void dumpDBbutton_Click(object sender, EventArgs e)
        {            
              
            BST tree = new BST();
            foreach(KeyValuePair<int,Animal> thisAni in animalsStorage)
            {
                if (thisAni.Value.getSpecies() != "Dog")
                {
                    tree.addToTree(thisAni.Value, thisAni.Value.getProf(Costs), thisAni.Key);
                }
            }           

            using (System.IO.StreamWriter writetext = new System.IO.StreamWriter("C:/Users/lands/Class Stuff/App Dev/New Text Document.txt"))
            {
                writetext.WriteLine(getIDDec(tree));
            }
            outBox1.Text = "Output successfully";
        }
    }
}
