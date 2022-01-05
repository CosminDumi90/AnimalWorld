using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Bat:Animal
    {
        private string name;
        private Categories category;
        private int maxSpeed;

        public Bat(string name, Categories category, int maxSpeed) : base(name, category, maxSpeed)
        {
            this.name = name;
            this.category = category;
            this.maxSpeed = maxSpeed;
        }
        public override void CanCrawl()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category} and i can crawl at {this.maxSpeed} m/s");
        }
        
        public override void CanFly()
        {
            Console.WriteLine($"Hy there my name is {this.name} and I am a {this.GetType().Name},if you didn't know that is a {this.category} and i can fly although i am not a {Categories.bird} at {this.maxSpeed * 44} m/s\n");
        }
    }
}
