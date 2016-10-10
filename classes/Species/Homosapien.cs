namespace Zoolandia.Animals
{
    public class Homosapien: Species
    {
        public Homosapien()
        {
            this.url = "http://www.iucnredlist.org/details/12551/0";
            this.scientificName = "Homosapien";
            this.commonName = "Human";
            this.genus = new Homo ();

            
        }
    }
}