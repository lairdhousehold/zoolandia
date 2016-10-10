using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
        // Create the first animal
          Monkey Billy = new Monkey("Billy", 5, 5);
          Billy.Species = new MacacaFascicularis();
          Billy.poopThrow();


         
           




        }
    }
}
