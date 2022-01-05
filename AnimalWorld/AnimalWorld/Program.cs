using System;

namespace AnimalWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal platypus = new Platypus("Perry", Categories.mammal,1);
            platypus.CanWalk();
            platypus.CanSwim();

            Animal bat = new Bat("Larry", Categories.mammal, 1);
            bat.CanCrawl();
            bat.CanFly();

            Animal wildDuck = new WildDuck("Daffy", Categories.bird, 1);
            wildDuck.CanFly();
            wildDuck.CanSwim();
            wildDuck.CanWalk();

            Animal ostrich = new Ostrich("Road Runner", Categories.bird, 20);
            ostrich.CanWalk();
            
        }
    }
}
