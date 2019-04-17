using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

public class CopperheadSnake : IWalking
{
    public string Name {get; set;}

    public CopperheadSnake (string name) {
        Name = name;
    }
    public void Run()
    {
        Console.WriteLine("Copperhead snake is slithering fast");
    }

    public void Walk()
    {
        Console.WriteLine("Copperhead snake is slithering slowly.");
    }
}
}
