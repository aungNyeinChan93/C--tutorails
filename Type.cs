using System;
using System.Collections.Generic;
using System.Text;

namespace tuto_01
{
    internal class Type
    {

        public string name = "type class";
        public void Do()
        {
            Console.WriteLine("Something do!");
        }

        public void Eat()
        {
            Console.WriteLine("Eat ... ");
        }


        public static void Main(string[] args)
        {
            Type t = new();
            t.Do();
            t.Eat();
            Console.WriteLine(t.name);
            t.name = "change";
            Console.WriteLine(t.name);
            Console.WriteLine(new Type().name = "change again");


            Type k = t;
            k.name = " change by k ";
            Console.WriteLine(t.name);
            Console.WriteLine(k.name);

        }


    }
}
