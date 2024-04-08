using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipCodePages
{
    public class City
    {
        public City(string name, string code, string state, string coordinates = "") 
        {   
            Name = name;
            ZipCode = code;
            State = state;
            Coordinates = coordinates;
        }

        public string Name { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }

        public string Coordinates {  get; set; }
    }
}
