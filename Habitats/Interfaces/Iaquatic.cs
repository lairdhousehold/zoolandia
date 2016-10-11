namespace Zoolandia.Habitats
{
    interface IAquatic
    {
        bool haswater{get;set;}
        string pumpType{get;set;}
        string HeaterType {get;set;}
        double HeaterTemp{get;set;}

    }
}