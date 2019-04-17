using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
public class Earthworm : IDigging
{
    public string Name {get; set;}

    public Earthworm (string name) {
        Name = name;
    }
   public void Dig() {
       Console.WriteLine("The earthworm is digging");
   }
}
}