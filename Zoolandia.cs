using System;
using Zoolandia.Animals;

namespace Zoolandia 
{
    public class Program
    {
        public static void Main(string[] args)
        {
        // Create the first animal
          MacacaFascicularis newMonkey = new MacacaFascicularis()
          {
              name = "felix",
              weight = 5,
              tailLength = 2,
              thumbCount = 4,
              
              
          };
          AilurusFulgens newPanda = new AilurusFulgens()
          {
              name = "bob",
              furColor = "red",
              weight = 50,
              highBodyfat = true
          };
          Homosapien newHuman = new Homosapien()
          {
              name = "larry",
              weight = 180,
              makesTools = true

          };
          Crocodylinae newCrocodile = new Crocodylinae("rufus", 1500, true);
          
            Console.WriteLine($"Your Monkey,{newMonkey.name}, weighs {newMonkey.weight} pounds");
            Console.WriteLine($"Your Panda,{newPanda.name}, is {newPanda.furColor} and fluffy");
            Console.WriteLine($"{newHuman.name}, weighs {newHuman.weight} pounds");
            Console.WriteLine($"Your Crocodile,{newCrocodile.name}, weighs {newCrocodile.weight} pounds"); 
            newCrocodile.eatingMonkeys();
            newMonkey.poopThrow();
            




        }
    }
}
