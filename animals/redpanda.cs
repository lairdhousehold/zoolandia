using System;


namespace Zoolandia.Animals
{
  public class AilurusFulgens : Animal
  {

    public string furColor { get; set; }
    public bool highBodyfat { get; set; }
   
    public void hide ()
    {
        Console.WriteLine("AilurusFulgens is hiding from all of the other crazie animals");
    }

   
    }
  }
