using System;


namespace Zoolandia
{
  public class MacacaFascicularis: Animal 
  {

    public int tailLength { get; set; }
    public int thumbCount { get; set; }
   
    public static void poopThrow ()
    {
        Console.WriteLine("Macaca-Fascicularis is now throwing poop at you");
    }

   
    }
  }
