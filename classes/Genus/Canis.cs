using System;



namespace Zoolandia.Animals
{
  public class Canis: Genus
  {

    public bool hasFourLegs { get; set; }
    public bool barks { get; set; }
    public bool isCarnivorus {get; set;}
 
    public void packRun ()
    {
        Console.WriteLine("{this.name} runs in packs");
    }

   
    }
  }
