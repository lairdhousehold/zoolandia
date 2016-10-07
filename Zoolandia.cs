using System;
using Zoolandia.Animals;

namespace Zoolandia 
{
    public class Program
    {
        public static void Main(string[] args)
        {
        // Create the first animal
          MacacaFascicularis newMonkey = new MacacaFascicularis("felix", 5, 5);
          MacacaFascicularis suerBob = new MacacaFascicularis("General Ass", 10, 15);
         
          AilurusFulgens newPanda = new AilurusFulgens("bob",50, true);
          AilurusFulgens crabapple = new AilurusFulgens("Cheese spanker", 20, true);
       
          Homosapien newHuman = new Homosapien("larry", 180, true);
          Homosapien stalkyHuman = new Homosapien("cee lo green", 300, true);
         
          Crocodylinae newCrocodile = new Crocodylinae("rufus", 1500, true);
          Crocodylinae meanlizard = new Crocodylinae("amos", 2000, true);
          
            Console.WriteLine($"Your Monkey,{newMonkey.name}, weighs {newMonkey.weight} pounds");
            Console.WriteLine($"Your Panda,{newPanda.name}, is {newPanda.furColor} and fluffy");
            Console.WriteLine($"{newHuman.name}, weighs {newHuman.weight} pounds");
            Console.WriteLine($"{stalkyHuman.name}, weighs {stalkyHuman.weight} pounds");
            Console.WriteLine($"Your Crocodile,{newCrocodile.name}, weighs {newCrocodile.weight} pounds"); 
            Console.WriteLine($"Your Crocodile,{meanlizard.name}, weighs {meanlizard.weight} pounds");
            Console.WriteLine($"{suerBob.name}");
            newCrocodile.eatingMonkeys();
            newMonkey.poopThrow();
            stalkyHuman.killCroc();
            stalkyHuman.poop();
            Console.WriteLine($"{crabapple.name} has an issue with Cheese cause his tail weighs {crabapple.weight} pounds");





        }
    }
}
