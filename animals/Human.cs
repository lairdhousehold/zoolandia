using System;
namespace Zoolandia.Animals
{
    public class Human: Animal
  {

    public bool bipedal { get; set; }
    public bool makesTools { get; set; }
    public Human(string name, int weight, bool makesTools)
    {
      this.name = name;
      this.weight = weight;
      this.makesTools = true;
    }
   
    public void killCroc ()
    {
        Console.WriteLine($"{this.name} has now shot the Crocodylinae that ate the  Macaca-Fascicularis that threw the poop at him");
    }
    public override void poop()
    {
      Console.WriteLine($"{this.name} is pooping in the grass");
    }

   
    }
  }
