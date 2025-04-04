using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver.SpecFlow.Exercise.Core
{
    public class Dress
    {
        public Dress(string name, string composition, string style, string property, string price, string color, 
            string size, int quantity)
        {
            Name = name;
            Composition = composition;
            Style = style;
            Property = property;
            Price = price;
            Color = color;
            Size = size;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public string Composition { get; set; }
        public string Style {  get; set; }
        public string Property {  get; set; }
        public string Price {  get; set; }
        public string Size {  get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
    }
}
