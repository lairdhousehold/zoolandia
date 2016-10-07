using System;
using Zoolandia.Animals;


namespace Zoolandia.Genus
{
  public class Psittacus: Animal 
  {

    public bool flys { get; set; }
    public bool eatsFruit { get; set; }
    public bool isDomesticated {get; set;}
   
    public override void eat()
    {
      Console.WriteLine($"{this.name} ate a banana");
    }
   
    public override void sleep ()
    {
        Console.WriteLine("{this.name} is kicking it all night");
    }

   
    }
  }
