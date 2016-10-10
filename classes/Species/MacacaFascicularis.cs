namespace Zoolandia.Animals
{
    public class MacacaFascicularis: Species
    {
        public MacacaFascicularis()
        {
            this.url = "http://www.iucnredlist.org/details/12551/0";
            this.scientificName = "MacacaFascicularis";
            this.commonName = "Monkey";
            this.genus = new Macaque ();

            
        }
    }
}