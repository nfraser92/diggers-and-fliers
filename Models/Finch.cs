using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

public class Finch : IFlier
{
    public string Name {get; set;}

    public Finch (string name) {
        Name = name;
    }
   public void Fly() {
       Console.WriteLine("The finch is now flying");
   }
   public void Land() {
       Console.WriteLine("The finch has landed");
   }
}
}