using System;



namespace Zoolandia.Animals
{
  public class RedPanda: Animal
  {

    public string furColor { get; set; }
    public bool highBodyfat { get; set; }
    public RedPanda(string name, int weight, bool highBodyfat)
    {
      this.name = name;
      this.weight = weight;
      this.highBodyfat = true;
    }
   
    public void hide ()
    {
        Console.WriteLine("AilurusFulgens is hiding from all of the other crazie animals");
    }

   
    }
  }
