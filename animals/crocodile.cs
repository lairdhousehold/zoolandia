using System;


namespace Zoolandia.Animals
{
  public class Crocodylinae: Animal 
  {

    public bool hasScales { get; set; }
    public bool amphibious { get; set; }
    public bool isCarnivorus {get; set;}
   
    public static void eatingMonkeys ()
    {
        Console.WriteLine("Crocodylinae is now eating Macaca-Fascicularis that threw poop at him");
    }

   
    }
  }
