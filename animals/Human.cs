using System;


namespace Zoolandia.Animals
{
  public class Homosapien: Animal 
  {

    public bool bipedal { get; set; }
    public bool makesTools { get; set; }
    public Homosapien(string name, int weight, bool makesTools)
    {
      this.name = name;
      this.weight = weight;
      this.makesTools = true;
    }
   
    public void killCroc ()
    {
        Console.WriteLine("Homosapien has now shot the Crocodylinae that ate the  Macaca-Fascicularis that threw the poop at him");
    }

   
    }
  }
