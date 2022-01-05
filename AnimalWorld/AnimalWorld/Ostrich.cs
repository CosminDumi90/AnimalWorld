using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Ostrich:Animal
    {
        private string name;
        private Categories category;
        private int maxSpeed;

        public Ostrich(string name, Categories category, int maxSpeed) : base(name, category, maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }

        public override void CanWalk()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category},i can't fly but i can run at {this.maxSpeed} m/s");
        }
    }
}
