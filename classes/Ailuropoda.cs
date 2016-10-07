using System;
using Zoolandia.Animals;


namespace Zoolandia.Genus
{
  public class Ailuropoda: Animal 
  {

    public bool climbstrees { get; set; }
    public bool isOmnivorous { get; set; }
    public bool liveInPacks {get; set;}
   
    public override void eat()
    {
      Console.WriteLine($"{this.name} eats bamboo");
    }
   
    public override void poop()
    {
        Console.WriteLine("{this.name} pops green");
    }

   
    }
  }