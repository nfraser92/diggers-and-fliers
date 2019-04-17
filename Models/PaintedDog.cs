using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
public class PaintedDog : IWalking
{
    public string Name {get; set;}

    public PaintedDog (string name) {
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
}
}
