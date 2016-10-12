using System;



namespace Zoolandia.Animals
{
  public class Monkey: Animal, IClimb
  {
    public double ClimbSpeed {get;set;}
    
    public int tailLength { get; set; }
    public int thumbCount { get; set; }
    public Monkey ( string name, int weight, int tailLength)
    {
      this.name = name;
      this.weight = weight;
      this.tailLength = tailLength;
    }
    public virtual void climb()
    {
      Console.WriteLine($"Climbiing my buns off"); 
    }
   
    public void poopThrow ()
    {
        Console.WriteLine($"{this.name} is now throwing poop at you");
    }

   
    }
  }
