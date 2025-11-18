using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace spore
{
    public class Creature // this is the blueprint for all of our creatures
    {
        public String name; // each creature will have a name
        public int age;
        public double birthRate; // each creature will have a birth rate, although we haven't really implemented it yet
        public double deathRate; // each creature will have a death rate
        public Creature() // this is a constructor method, we can call it to create an instance of our class, in this case: a Creature
        {
            // since this is the empty constructor (we don't pass this method any values), it will be a default creature
            this.name = "Creature"; // this creatures name is 'Creature'
            this.age = 0;
            this.birthRate = 1; // this creature has a birth rate of 1
            this.deathRate = 0.1; // this creature has a death rate of 0.1
        }

        public Creature(string name, double birthRate, double deathRate) // this constructor is a bit more complicated, 
        {
            this.name = name;
            this.age = 0;
            this.birthRate = birthRate;
            this.deathRate = deathRate;
        }

        public Creature(string name, int age, double birthRate, double deathRate)
        {
            this.name = name;
            this.age = age;
            this.birthRate = birthRate;
            this.deathRate = deathRate;
        }

        public override string ToString()
        {
            return String.Concat(this.name + " the " + this.age + " year old creature");
        }
    }
}
