using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var PaintedDog = new LandAnimal() { Name = "Painted Dog" };
            var SeaTurtle = new Amphibian() { Name = "Sea Turtle" };
            var Finch = new SkyAnimal() { Name = "Finch" };
            var Shark = new WaterAnimal() { Name = "Shark" };
            var Bear = new LandAnimal() { Name = "Bear" };
            var PoisonFrog = new Amphibian() { Name = "Poison Frog" };
            var Eagle = new SkyAnimal() { Name = "Eagle" };
            var Seahorse = new WaterAnimal() { Name = "Seahorse" };

            var FlyerContainer = new FlyerContainer();
            FlyerContainer.Fliers = new List<IFlying>() { Finch, Eagle };

            var SwimmerContainer = new SwimmersContainer();
            SwimmerContainer.swimmers = new List<ISwimming>() { SeaTurtle, Shark, PoisonFrog, Seahorse };

            var WalkerContainer = new WalkersContainer();
            WalkerContainer.walkers = new List<IWalking>() { SeaTurtle, PoisonFrog, PaintedDog, Finch, Bear, Eagle };
        }
    }
}
