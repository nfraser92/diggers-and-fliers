using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

public class BettaFish : ISwimming
{
    public string Name {get; set;}

    public BettaFish (string name) {
        Name = name;
    }
    public int MaximumDepth { get; } = 100;

    public void Swim()
    {
        Console.WriteLine("Betta Fish is now swimming");
    }
}
}