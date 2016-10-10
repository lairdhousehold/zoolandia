using System;



namespace Zoolandia.Animals
{
  public class Monkey: Animal
  {
    
    public int tailLength { get; set; }
    public int thumbCount { get; set; }
    public Monkey ( string name, int weight, int tailLength0)
    {
      this.name = name;
      this.weight = weight;
      this.tailLength = tailLength;
    }
   
    public void poopThrow ()
    {
        Console.WriteLine($"{this.name} is now throwing poop at you");
    }

   
    }
  }
