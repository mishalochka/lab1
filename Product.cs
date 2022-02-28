using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    public class Product
    {
        public string name { get; set; }

        public Product(string _name)
        {
            name = _name;
        }

        public Product()
        {
            name = "";
        }
    }
}
