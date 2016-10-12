namespace Zoolandia.Habitats
{
    public class Forrest :Habitat, IWooded
    {
        
        public bool IsFenced {get;set;}
        public bool HasTrees {get;set;}
        public bool HasFences{get;set;}
         public Forrest (string Name, bool HasTrees, bool HasFences )
        {
            this.Name = Name;
            this.HasTrees =HasTrees;
            this.HasFences = HasFences;
        }
        
    }
}
