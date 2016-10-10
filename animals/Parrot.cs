//
using System;




namespace Zoolandia.Animals
{
  public class parrot:Animal 
  {

    public bool canImitateSounds { get; set; }
    public bool isColorful { get; set; }
    public bool isVegitarian {get; set;}
    public parrot(string name, int weight, bool isVegitarian )
    
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
