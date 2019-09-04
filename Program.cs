using System;
using System.Collections.Generic;
using Sandwiches;

namespace Whatever
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandwich s1 = new Sandwich();
            s1.toastSandwich();
            Sandwich s2 = new Sandwich(
                "white",
                new List<string>() {"turkey", "bacon"},
                new List<string>() {"lettuce", "tomato", "avacado"},
                new List<string>() {"mayo"},
                8.12,
                500,
                true
            );
            Console.WriteLine(s1.getDescription());
            Console.WriteLine(s2.getDescription());
            Panini p1 = new Panini(
                "baguette",
                new List<string>() {"ham", "roasted pork"},
                new List<string>() {"swiss cheese"},
                new List<string>() {"mustard"},
                7.75,
                550
            );
            Console.WriteLine(p1.getDescription());
        }
    }
}
