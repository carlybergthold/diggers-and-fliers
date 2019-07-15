using System;

namespace Animals
{
    public class SkyAnimal : Animal, IFlying, IWalking
    {

        public int MaxHeight { get; set; }
        public string WingLength { get; set; }
        public void Fly()
        {
            Console.WriteLine($"{Name} is now flying");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking");
        }
        public void Run()
        {
            Console.WriteLine($"{Name} is now running");
        }
    }
}