using System;
using System.Collections.Generic;

namespace Sandwiches
{
    public class Panini: Sandwich
    {
        public Panini(string b, List<string> p, List<string> t, List<string> c, double pr, int cal) : 
        base(b, p, t, c, pr, cal, true) 
        { }
        
    }
}