using System;

namespace Zoolandia
{
    public class Animal
    {
        public string name { get; set; }
        public int  height{ get; set;}
        public int  weight{ get; set;}
        

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
