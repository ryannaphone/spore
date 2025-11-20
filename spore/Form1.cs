namespace spore
{
    public partial class Form1 : Form
    {
        Creature[] creatures = new Creature[0]; // declare our creature arrary, we will use it later
        public int year = 1;
        public Form1()
        {
            InitializeComponent(); // create our window elements and stuff
            timer1.Start(); // start our timer
        }

        private void button1_Click(object sender, EventArgs e) // this method gets called when we click our button
        {
            creatures = extendCreatures(creatures, randomCreature()); // adds a new creature to our creatures array
        }

        public Creature[] extendCreatures(Creature[] creatures, Creature c)
        {
            Creature[] newCreatures = new Creature[creatures.Length + 1]; // create a new array to store our expanded array of creatues

            for (int i = 0; i < creatures.Length; i++) // use a for loop to go through each item of the array
            {
                newCreatures[i] = creatures[i]; //set the new array item to the old array item
            }
            newCreatures[newCreatures.Length - 1] = c; // add our new creature to the end of the array
            return newCreatures; // return the new array
        }

        public Creature[] removeCreatures(Creature[] creatures, int index)
        {
            Creature[] newCreatures = new Creature[creatures.Length - 1]; // create a new array to store our reduced array of creatues

            if (index == 0) // handle the case where we are removing the first creature
            {
                for (int i = 1; i < creatures.Length; i++) // create a for loop that goes from 1 to the end of the creatures array
                {
                    newCreatures[i - 1] = creatures[i]; // set each newCreature to the corresponding creature
                }
            }
            else if (index == creatures.Length - 1) // handle the case where we are removing the last creature
            {
                for (int i = 0; i < creatures.Length - 1; i++) // create a for loop that goes from 0 to the second to last creature in the array
                {
                    newCreatures[i] = creatures[i]; // set each newCreature to the corresponding creature
                }
            }
            else // handle the case where we are removing a middle creature
            {
                for (int i = 0; i < index; i++) // create a for loop that goes from 0 to the number just before the index of the creature we are removing
                {
                    newCreatures[i] = creatures[i]; // set each newCreature to the corresponding creature. these are the creatures we are keeping
                }
                for (int i = index + 1; i < creatures.Length; ++i) // create another for loop that goes from the index just after the one we are removing to the end of the creatures array
                {
                    newCreatures[i - 1] = creatures[i]; // set each newCreature to the corresponding creature. Note this does not contain the removed creature
                }
            }
            return newCreatures; // return the array that does not include the creature at the index given
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ageCreatures();
            label1.Text = creatures.Length.ToString();
            listBox1.Items.Clear(); // remove the list of creatures from the listBox
            for (int i = 0; i < creatures.Length; i++) // for each creature ...
            {
                listBox1.Items.Add(creatures[i].ToString()); // ... add the toString to the listBox
            }
            yearLabel.Text = year.ToString();
            year++;

        }

        public void ageCreatures() // call this method to age all creatures
        {
            Random r = new Random(); // create new random object 
            if (creatures.Length > 0) // only execute this code if there are creatures
            {
                for (int i = 0; i < creatures.Length; i++) // go through each creature using a for loop
                {
                    creatures[i].age++;
                    double randomDoub = r.NextDouble(); // create a random double
                    if (willCreatureDie(creatures[i])) // if the random double is greater than the deathRate of our creature...
                    {
                        //label1.Text = "Creature destroyed " + randomDoub.ToString(); // this was for debugging >:{
                        creatures = removeCreatures(creatures, i); // the creature dies.
                    }

                }
            }
        }

        public Creature randomCreature() // call this method to create a random creature
        {

            Random rand = new Random();
            int r = rand.Next(100); // create a random integer
            String name; // we need a name for our random creature
            double deathRate; // and a death rate for our creature
            double birthRate = 1; // we haven't implemented our birth rate yet, so lets just put it to 1
            switch (r) // lets handle each instance of r with a switch case 
            {
                case 0: // if r is 0, lets do this
                    name = "Jim"; // in case 0, this creature will be named Jim
                    deathRate = rand.NextDouble(); // the death rate will be random
                    break; // this 'break' statement causes us to skip past the other cases and finish the rest method

                case 1: // if r is 1, lets do this
                    name = "Etta"; // in case 1, this creature will be named Etta
                    deathRate = 0.123; // this creature will have a death rate of 0.123
                    break;
                case 2: // if r is 2, lets do this
                    name = "bell"; // this creature will be named bell
                    deathRate = 0.22; // all bell's will have a death rate of 0.22
                    break;
                case 3: // if r is 3, lets do this
                    name = "Gandalf"; // This creature is called Gandalf
                    deathRate = 0.001; // Gandalf is special
                    break;

                case 4:
                    name = "Finn";
                    deathRate = rand.NextDouble() / 2;
                    break;
                default: // this will be the default case
                         // (So this is the case where r is not handled by another case, in other words, when r is a number other than 0, 1, 2, or 3)
                    name = "Barry";  // default creatures will be named Barry;
                    deathRate = 0.1; // Default Barrys will have a default death rate of 0.1
                    break;
            }


            Creature c = new Creature(name, birthRate, deathRate); // now we actually create our creature with the values we picked above
            c.ToString(); // this statement was used for debugging.
            return c; // return the finished random creature so we can use it
        }

        private void speedUpButton_Click(object sender, EventArgs e)
        {
            if (timer1.Interval - 100 > 0) timer1.Interval -= 100;
            else if (timer1.Interval - 10 > 0) timer1.Interval -= 10;
        }

        private void speedDownButton_Click(object sender, EventArgs e)
        {
            if (timer1.Interval + 100 < 5000) timer1.Interval += 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                creatures = extendCreatures(creatures, randomCreature()); // adds a new creature to our creatures array
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                creatures = extendCreatures(creatures, randomCreature()); // adds a new creature to our creatures array
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                creatures = extendCreatures(creatures, randomCreature()); // adds a new creature to our creatures array
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                creatures = extendCreatures(creatures, randomCreature()); // adds a new creature to our creatures array
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            } else
            {
                timer1.Start();
            }
        }

        public Boolean willCreatureDie(Creature c)
        {
            Random r = new Random();
            double randomDoub = r.NextDouble(); // create a random double
            for (int i = 0; i < c.age; i++) 
            { 
                if (randomDoub < c.deathRate) // if the random double is greater than the deathRate of our creature...
                {
                    //label1.Text = "Creature destroyed " + randomDoub.ToString(); // this was for debugging >:{
                    return true; // the creature dies.
                }
            }

            return false;
        }
    }
}
