using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Platypus:Animal
    {
        private string name;
        private Categories category;
        private int maxSpeed;
        
       
        public Platypus(string name,Categories category,int maxSpeed) : base(name, category, maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }

        public override void CanWalk()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category} and i can walk at {this.maxSpeed} m/s");
        }
        public override void CanSwim()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category} and i can swim at {this.maxSpeed * 2} m/s\n");
        }
    }
}
