using System;
using System.Collections.Generic;

namespace Sandwiches
{
    public class Sandwich
    {
        public string bread;
        public List<string> proteins;
        public List<string> toppings;
        public List<string> condiments;
        public double price;
        public int calories;
        private bool _isHot = false;
        public bool isHot {get {return _isHot;}}
        public Sandwich (string b, List<string> p, List<string> t, List<string> c, double pr, int cal, bool iH) 
        {
            this.bread = b;
            this.proteins = p;
            this.toppings = t;
            this.condiments = c;
            this.price = pr;
            this.calories = cal;
            this._isHot = iH;
        }
        public Sandwich () 
        {
            this.bread = "extra crusty wheat bread";
            this.proteins = new List<string>() {"Peanut Butter"};
            this.toppings = new List<string>();
            this.condiments = new List<string>() {"Durian Jelly"};
            this.price = 3.50;
            this.calories = 200;
            this._isHot = false;
        }
        public string getDescription()
        {
            string description = "";
            description += $"Bread:      {this.bread}\n";
            description += $"Protein:    {String.Join(", ", this.proteins)}\n";
            description += $"Toppings:   {String.Join(", ", this.toppings)}\n";
            description += $"Condiments: {String.Join(", ", this.condiments)}\n";
            description += $"Price:      ${this.price}\n";
            description += $"Calories:   {this.calories} kCal\n";
            description += $"Is Hot?:    {this.isHot}";
            return description;
        }
        public void toastSandwich() {
            this._isHot = true;
        }
    }
}