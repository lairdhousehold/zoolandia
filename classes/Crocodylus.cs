using System;
using Zoolandia.Animals;


namespace Zoolandia.Genus
{
  public class Crocodylus: Animal 
  {

    public bool hasScales { get; set; }
    public bool amphibious { get; set; }
    public bool isCarnivorus {get; set;}
   
    public override void eat()
    {
      Console.WriteLine($"the {this.name} doesn't eat he consumes life");
    }
   
    public void eatingMeat ()
    {
        Console.WriteLine("Crocodylinae is now eating looking for poop throwers");
    }

   
    }
  }
