namespace Zoolandia.Habitats
{
    public class House:Habitat
    {
        public string name {get;set;}
        public bool HasDoors {get;set;}
        public bool HousesWorkers {get;set;}
         public House (string Name, bool HousesWorkers, bool HasDoors )
        {
            this.Name = Name;
            this.HasDoors = HasDoors;
            this.HousesWorkers = HousesWorkers;
        }
        
    }
}
