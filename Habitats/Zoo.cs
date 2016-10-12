using System.Collections.Generic;
using Zoolandia.Animals;
using System;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Zoo
    {
        public double Width {get;set;}
        public double Length{get;set;}
        public string name {get;set;}
        public string location{get;set;}
        public List<Habitat>Habitats = new List<Habitat>();

        public virtual void ZooGreeting()
        {
            Console.WriteLine($"Welcome to {this.name} we have some real wild creatures here");
        }


    }
}