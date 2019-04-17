using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
public class Terrapin : ISwimming, IWalking
{
    public string Name {get; set;}

    public Terrapin (string name) {
        Name = name;
    }
   public int MaximumDepth { get; } = 50;

    public void Run()
    {
        Console.WriteLine("Terrapin is now running. Kind of.");
    }

    public void Walk()
    {
        Console.WriteLine("Terrapin is now walking");
    }

    public void Swim()
    {
        Console.WriteLine("Terrapin is now swimming");
    }
}
}