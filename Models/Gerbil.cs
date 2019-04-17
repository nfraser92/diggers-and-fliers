using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
public class Gerbil : IDigging, IWalking
{
    public string Name {get; set;}

    public Gerbil (string name) {
        Name = name;
    }
   public void Dig() {
       Console.WriteLine("The Gerbils are digging");
   }
   public void Run() {
       Console.WriteLine("The Gerbils are digging");
   }
   public void Walk() {
       Console.WriteLine("The Gerbils are digging");
   }
}
}