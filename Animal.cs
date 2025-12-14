using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace tuto_01
{
    internal class Animal
    {

        string type = "Dog";
        static int age = 10;
        string name;

        public void Run(string type)
        {
            this.type = type;
            Console.WriteLine(this.type + " running ...");
            Animal.Name();
            age++;
            Animal.age++;
            Console.WriteLine(Animal.age);

        }

        static void Name()
        {
            var name = " shwe war";
            Animal a = new ();
            a.name = name;
            Console.WriteLine(a.name);
            Console.WriteLine(a.type);
            Console.WriteLine(Animal.age);
        }

        public string Eat()
        {
            return "eating ..." + this.type;
        }

        public static string Sleep()
        {
            return "Sleep ... ";
        }


    }
}
