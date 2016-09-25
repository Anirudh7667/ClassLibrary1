using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraryZoo
{
    public class Zoo
    {
        public string location;

        public string owner;

        public int numOfSpecimens;

        public int numOfAnimals;

        public int numOfBirds;

        public Zoo(string l, string o, int ns, int na, int nb)
        {
            this.location = l;
            this.owner = o;
            this.numOfSpecimens = ns;
            this.numOfAnimals = na;
            this.numOfBirds = nb;
        }

        public void AddSpecimen(string t)
        {
            this.numOfSpecimens++;
            if (t == "Animal")
            {
                this.numOfAnimals++;
            }
            else
            {
                this.numOfBirds++;
            }
        }

    }

    public class Specimen
    {
         enum ZooSpecimens
         {
                Lion = 1,
                Tiger,
                Elephant,
                Giraffe,
                SnowLeopard,
                Eagle,
                Vulture,
                Owl,
                Crane,
                Cockatoo
         }

            public string type;

        public int age;

            public string funFact;

            public int cageNo;

            public int weight;

        public int daySinceFed;

        public bool isPair;
        }

    public class Animals
    {
        public bool isCarnivore;

        public string regionOfOrigin;

        public int numOfLegs;
    }

    public class Birds
    {
        public bool isExotic;

        public bool canFly;

        public string color;

    }

    public interface Feeder
    {
         void feedSpecimen(int w);
    }

    public interface Maintenance
    {
        void maintainCage(int cn);
    }

    public interface Breeder
    {
        void getBaby(int a, bool i);
    }

    }

