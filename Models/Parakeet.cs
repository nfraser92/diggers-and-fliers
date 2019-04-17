using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

public class Parakeet : IFlier
{
    public string Name {get; set;}

    public Parakeet (string name) {
        Name = name;
    }
   public void Fly() {
       Console.WriteLine("The parakeet is now flying");
   }
   public void Land() {
       Console.WriteLine("The parakeet has landed");
   }
}
}