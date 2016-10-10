using System;




namespace Zoolandia.Animals
{
  public class Dog:Animal
  {

    public bool isDomesticated { get; set; }
    public bool isPlayful { get; set; }
    public bool cohabitatesWithHumans {get; set;}
    public Dog(string name, int weight, bool isDomesticated )
    
    { 
      this.name = name;
      this.weight = weight;
      this.isDomesticated = true;
    }

    public override void poop()
    {
      Console.WriteLine($"{this.name} pooped in the neighbors yard");
    }
   
    public void playingFrisbee ()
    {
        Console.WriteLine("{this.name} is playing frisbee");

   
    }
  }
}