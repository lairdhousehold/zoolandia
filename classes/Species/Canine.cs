namespace Zoolandia.Animals
{
    public class Canine: Species
    {
        public Canine()
        {
            this.url = "http://www.iucnredlist.org/details/12551/0";
            this.scientificName = "Canine";
            this.commonName = "Dog";
            this.genus = new Canis ();

            
        }
    }
}