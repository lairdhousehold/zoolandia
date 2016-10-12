namespace Zoolandia.Habitats
{
    public class Park:Habitat, IWooded
    {
        public string name {get;set;}
        public bool IsForHumanAnimalInteraction {get;set;}
        public bool HasPublicBathrooms {get;set;}
        public bool HasTrees {get; set;}
        public bool HasFences{get;set;}
        public Park (string Name, bool HasTrees, bool HasFences )
        {
            this.Name = Name;
            this.HasTrees =HasTrees;
            this.HasFences = HasFences;
        }


        
    }
}
