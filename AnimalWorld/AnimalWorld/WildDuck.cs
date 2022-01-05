using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class WildDuck:Animal
    {
        private string name;
        private Categories category;
        private int maxSpeed;


        public WildDuck(string name, Categories category, int maxSpeed) : base(name, category, maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }

        public override void CanWalk()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category} and i can walk at {this.maxSpeed*3} m/s\n");
        }
        public override void CanSwim()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category} and i can swim at {this.maxSpeed} m/s");
        }
        public override void CanFly()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category} and i can fly at {this.maxSpeed*22} m/s");
        }
    }
}
