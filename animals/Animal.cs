using System;

namespace Zoolandia.Animals
{
    public class Animal{
        public string name { get; set; }
        public string height{ get; set;}

        public string weight{ get; set;}

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
        public static void eat ()
        {
            Console.WriteLine("Animal is now eating");
        }
        public static void poop()
        {
            Console.WriteLine("Animal is now pooping");
        }
    }

} 
