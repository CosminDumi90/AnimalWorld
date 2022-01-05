using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public enum Categories
    {
        mammal,
        fish,
        bird,
        reptile,
        insect
    }


    public class Animal : IFly, IWalk, ISwim, ICrawl
    {
        private string name;
        private Categories category;
        private int maxSpeed;

        public string Name { get { return name; } }
        public Categories Category { get { return category; } }



        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

           
        }

        public Animal(string name, Categories category, int maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }

        public virtual void CanFly()
        {
            Console.WriteLine($"I am a {this.GetType().Name} and i can fly at {this.maxSpeed}");
        }

        public virtual void CanWalk()
        {
            Console.WriteLine($"I am a {this.GetType().Name} and i can walk at {this.maxSpeed}");
        }

        public virtual void CanSwim()
        {
            Console.WriteLine($"I am a {this.GetType().Name} and i can swim");
        }

        public virtual void CanCrawl()
        {
            Console.WriteLine($"I am a {this.GetType().Name} and i can crawl");
        }
    }




}
