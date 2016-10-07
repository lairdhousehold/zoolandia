using System;


namespace Zoolandia.Animals 
{
  public class MacacaFascicularis: Animal 
  {

    public string tailLength { get; set; }
    public string thumbCount { get; set; }
   
    public static void poopThrow ()
    {
        Console.WriteLine("Macaca-Fascicularis is now throwing poop at you");
    }

   
    }
  }
