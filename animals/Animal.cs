using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public int  height{ get; set;}
        public int  weight{ get; set;}
        

        public virtual void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
        public virtual void eat ()
        {
            Console.WriteLine("Animal is now eating");
        }
        public virtual void poop()
        {
            Console.WriteLine("Animal is now pooping");
        }

    }

} 
