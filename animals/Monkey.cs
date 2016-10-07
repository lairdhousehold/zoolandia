using System;


namespace Zoolandia.Animals
{
  public class MacacaFascicularis: Animal 
  {

    public int tailLength { get; set; }
    public int thumbCount { get; set; }
   
    public void poopThrow ()
    {
        Console.WriteLine("Macaca-Fascicularis is now throwing poop at you");
    }

   
    }
  }
