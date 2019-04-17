using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
public class SeaTurtle : IWalking, ISwimming
{
    public string Name {get; set;}

    public SeaTurtle (string name) {
        Name = name;
    }
    public void Run()
    {
        Console.WriteLine("Animal is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Animal is now walking");
    }

    public int MaximumDepth { get; } = 100;

    public void Swim()
    {
        Console.WriteLine("Turtle is now swimming");
    }
}
}
