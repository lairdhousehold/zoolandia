using System;




namespace Zoolandia.Animals
{
  public class Crocodile:Animal
  {

    public bool narrowSnout { get; set; }
    public bool isAgressive { get; set; }
    public bool isFreshWater {get; set;}
    public Crocodile(string name, int weight, bool hasScales )
    
    { 
      this.name = name;
      this.weight = weight;
      this.isFreshWater = true;
    }

    public override void poop()
    {
      Console.WriteLine($"{this.name} pooped a monkey");
    }
   
    public void eatingMonkeys ()
    {
        Console.WriteLine("Crocodylinae is now eating Macaca-Fascicularis that threw poop at him");
    }

   
    }
  }
