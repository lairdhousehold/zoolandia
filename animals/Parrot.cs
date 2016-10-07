//
using System;
using Zoolandia.Genus;



namespace Zoolandia.Animals
{
  public class Psittacuserithacus:Psittacus  
  {

    public bool canImitateSounds { get; set; }
    public bool isColorful { get; set; }
    public bool isVegitarian {get; set;}
    public Psittacuserithacus(string name, int weight, bool isVegitarian )
    
    { 
      this.name = name;
      this.weight = weight;
      this.isVegitarian = true;
    }

    public override void poop()
    {
      Console.WriteLine($"{this.name} pooped bird seed");
    }
   
    public void matingDance ()
    {
        Console.WriteLine("{this.name} is now getting his groove on ");
    }

   
    }
  }
