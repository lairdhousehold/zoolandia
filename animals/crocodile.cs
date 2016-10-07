using System;


namespace Zoolandia.Animals
{
  public class Crocodylinae: Animal 
  {

    public bool hasScales { get; set; }
    public bool amphibious { get; set; }
    public bool isCarnivorus {get; set;}
    public Crocodylinae(string name, int weight, bool hasScales )
    
    { 
      this.name = name;
      this.weight = weight;
      this.hasScales = true;
    }

    public override void eat()
    {
      Console.WriteLine($"the {this.name} doesn't eat it consumes life");
    }
   
    public void eatingMonkeys ()
    {
        Console.WriteLine("Crocodylinae is now eating Macaca-Fascicularis that threw poop at him");
    }

   
    }
  }
