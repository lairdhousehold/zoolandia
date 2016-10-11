namespace Zoolandia.Habitats
{
    public class Swamp:Habitat, IAquatic
    {
        public string name {get;set;}
        public bool IsDamp {get;set;}
        public bool HasTropicalPlants {get;set;}
        public bool haswater{get;set;}
        public string pumpType{get;set;}
        public string HeaterType {get;set;}
        public double HeaterTemp{get;set;}
        
    }
}
