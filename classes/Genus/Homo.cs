using System;



namespace Zoolandia.Animals
{
  public class Homo: Genus 
  {

    public bool usesLanguage { get; set; }
    public bool LargeBrain { get; set; }
    public bool liveInPacks {get; set;}

    public void packRun ()
    {
        Console.WriteLine("{this.name} runs in packs");
    }

   
    }
  }
