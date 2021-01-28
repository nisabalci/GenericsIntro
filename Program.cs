using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Nisa");

            Console.WriteLine(names.Length);

            names.Add("Beyza");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Hello World!");

        }
    }
}