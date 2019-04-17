using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

public class Ants : IDigging, IWalking
{

    public string Name {get; set;}

    public Ants (string name) {
        Name = name;
    }
   public void Dig() {
       Console.WriteLine("The ants are digging");
   }
   public void Run() {
       Console.WriteLine("The ants are digging");
   }
   public void Walk() {
       Console.WriteLine("The ants are digging");
   }
}
}