using System;
using Zoolandia.Animals;


namespace Zoolandia.Genus
{
  public class Canis: Animal 
  {

    public bool hasFourLegs { get; set; }
    public bool barks { get; set; }
    public bool isCarnivorus {get; set;}
   
    public override void eat()
    {
      Console.WriteLine($"{this.name} like to chase thier food");
    }
   
    public void packRun ()
    {
        Console.WriteLine("{this.name} runs in packs");
    }

   
    }
  }
