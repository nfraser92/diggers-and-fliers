using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    public class Program
    {
        static void Main(string[] args)
        {
        // Create containers for animals to be put into
        FlyingContainer FlyingAnimals = new FlyingContainer();
        DiggerContainer DiggingAnimals = new DiggerContainer();
        SwimmingContainer SwimmingAnimals = new SwimmingContainer();
        WalkingContainer WalkingAnimals = new WalkingContainer();

        WalkingAnimals.Container.Add(new PaintedDog("Paul the Dug"));
        WalkingAnimals.Container.Add(new Ants("Ant the Ant"));
        SwimmingAnimals.Container.Add(new SeaTurtle("Tommy the turtle"));
        SwimmingAnimals.Container.Add(new BettaFish("Franny the Fish"));
        DiggingAnimals.Container.Add(new Earthworm("Eddie the Earthworm"));
        FlyingAnimals.Container.Add(new Finch("Frank the Finch"));
        DiggingAnimals.Container.Add(new Gerbil("Gerry the Gerbil"));
        DiggingAnimals.Container.Add(new Mice("Mikey the Mouse"));
        FlyingAnimals.Container.Add(new Parakeet("Peter the Parakeet"));
        WalkingAnimals.Container.Add(new Rattlesnake("Ralph the Rattlesnake"));
        SwimmingAnimals.Container.Add(new Terrapin("Tara the Terrapin"));


        WalkingAnimals.Container.ForEach(animal => Console.WriteLine($"Walking container holds {WalkingAnimals.Container.Count} animals"));
        FlyingAnimals.Container.ForEach(animal => Console.WriteLine($"Flying container holds {FlyingAnimals.Container.Count} animals"));
        DiggingAnimals.Container.ForEach(animal => Console.WriteLine($"Digging container holds {DiggingAnimals.Container.Count} animals"));
        SwimmingAnimals.Container.ForEach(animal => Console.WriteLine($"Swimming container holds {SwimmingAnimals.Container.Count} animals"));
        }

    }
}
