using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
public class Rattlesnake : IWalking
{
    public string Name {get; set;}

    public Rattlesnake (string name) {
        Name = name;
    }
    public void Run()
    {
        Console.WriteLine("Rattlesnake is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Rattlesnake is now walking");
    }
}
}
