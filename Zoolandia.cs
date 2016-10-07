using System;
using Zoolandia.Animals;

namespace Zoolandia 
{
    public class Program
    {
        public static void Main(string[] args)
        {
        // Create the first animal
          Animal newMonkey = new MacacaFascicularis()
          {
              name = "felix",
              weight = 5,
              tailLength = 2,
              thumbCount = 4,
              
              
          };
          Animal newPanda = new AilurusFulgens()
          {
              name = "bob",
              furColor = "red",
              weight = 50,
              highBodyfat = true
          };
          Animal newHuman = new Homosapien()
          {
              name = "larry",
              weight = 180,
              makesTools = true

          };
          Animal newCrocodile = new Crocodylinae()
          {
              name = "rufus",
              weight = 1500,
              isCarnivorus = true

          };
            Console.WriteLine($"Your Monkey,{newMonkey.name}, weighs {newMonkey.weight} pounds");
            Console.WriteLine($"Your Panda,{newPanda.name}, is {newPanda.furColor} pounds");
            Console.WriteLine($"{newHuman.name}, weighs {newHuman.weight} pounds");
            Console.WriteLine($"Your Crocodile,{newCrocodile.name}, weighs {newCrocodile.weight} pounds");
            
          





          






        }
    }
}
