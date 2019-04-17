using System;
using System.Collections.Generic;

namespace diggers_and_fliers {
public class Mice : IDigging, IWalking
{
    public string Name {get; set;}

    public Mice (string name) {
        Name = name;
    }
   public void Dig() {
       Console.WriteLine("The mice are digging");
   }
   public void Run() {
       Console.WriteLine("The mice are digging");
   }
   public void Walk() {
       Console.WriteLine("The mice are digging");
   }
}
}