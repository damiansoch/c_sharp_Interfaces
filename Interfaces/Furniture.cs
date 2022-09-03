using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set;}

        //default coustructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        //simple constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
