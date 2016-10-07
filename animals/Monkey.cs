using System;
using Zoolandia.Genus;


namespace Zoolandia.Animals
{
  public class MacacaFascicularis: Macaque 
  {

    public int tailLength { get; set; }
    public int thumbCount { get; set; }
    public MacacaFascicularis( string name, int weight, int tailLength0)
    {
      this.name= name;
      this.weight = weight;
      this.tailLength = tailLength;
    }
   
    public void poopThrow ()
    {
        Console.WriteLine("Macaca-Fascicularis is now throwing poop at you");
    }

   
    }
  }
