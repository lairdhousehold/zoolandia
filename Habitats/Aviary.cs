namespace Zoolandia.Habitats
{
    public class aviary :Habitat,IWooded
    {
        public string name {get;set;}
        public bool IsNetted {get;set;}
        public bool HasTrees{get;set;}
        public bool HasFences{get;set;}
        public aviary (string Name, bool HasTrees, bool HasFences )
    {
        this.Name = Name;
        this.HasTrees =HasTrees;
        this.HasFences = HasFences;
    }
        
    }
}
