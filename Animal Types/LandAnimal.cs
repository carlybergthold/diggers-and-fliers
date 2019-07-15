using System;

namespace Animals
{
    public class LandAnimal : Animal, IWalking
    {
        public int Speed { get; set; }
        public string NumberOfLegs { get; set; }
        public void Run()
        {
            Console.WriteLine($"{Name} is now running");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking");
        }
    }
}