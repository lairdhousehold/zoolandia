using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public class Habitat
    {
        public double Widith {get; set;}
        public double Height {get; set;}
        public double Depth {get;set;}
        public string Name {get; set;}
        public List<Animal>inhabitants = new List<Animal>();
    }

}

