using Zoolandia.Animals;
using System;
using Zoolandia.Habitats;
using System.Collections.Generic;

namespace Zoolandia
{
     class Zoolandia
    {
        public static void Main(string[] args)
        {
        // Create the first animal
          Park Funland = new Park ("Dog Land", true, true);
          aviary BirdHouse = new aviary("Birdy McBirdface", true, true);
          Forrest BootyTrees = new Forrest("BootyTree", true, true);
          House HumanManor = new House("FalconCrest", true, true);
          Swamp FunkBog = new Swamp ("bogolisicious", 88 );
          FunkBog.Swampee();

          Human UglyDude = new Human("Carl", 290, false);
          UglyDude.Species = new Homosapien();
          UglyDude.poop();

          Monkey Billy = new Monkey("Billy", 5, 5);
          Billy.Species = new MacacaFascicularis();
          Billy.poopThrow();
          parrot BlueParrot = new parrot("Bart", 5, true);
          BlueParrot.Species = new Psittacuserithacus();
          BlueParrot.poop();

          Crocodile NileCroc = new Crocodile("Ned", 500, true);
          NileCroc.Species = new Crocodylinea();
          NileCroc.poop();
          Dog Shepard = new Dog("Rufus", 85, true);
          Shepard.Species = new Canine ();
          RedPanda DeFurBear = new RedPanda("Bob",300,true );
          DeFurBear.Species = new AilurusFulgens();


          Zoo Zoolandia = new Zoo ();
          Zoolandia.Habitats.Add(FunkBog);
          Zoolandia.Habitats.Add(Funland);
          Zoolandia.Habitats.Add(BirdHouse);
          Zoolandia.Habitats.Add(BootyTrees);
          Zoolandia.Habitats.Add(HumanManor);
          FunkBog.inhabitants.Add(NileCroc);
          Funland.inhabitants.Add(Shepard);
          BirdHouse.inhabitants.Add(BlueParrot);
          BootyTrees.inhabitants.Add(Billy);
          HumanManor.inhabitants.Add(UglyDude);
          
          
          foreach(Habitat Habitats in Zoolandia.Habitats)
            {
            Console.WriteLine($"{Habitats.Name}\nAnimals in this habitat:");
            foreach (Animal Animals in Habitats.inhabitants)
              {
                Console.WriteLine($"{Animals.name} the {Animals.Species} genus {Animals.Species.genus}");
        
        }
      }







        }
    }
}
