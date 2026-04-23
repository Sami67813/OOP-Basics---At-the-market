using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics___At_the_market
{
    internal class Product
    {
        private string name;
        private int value;
        public string Name { get { return name; }
            set { name = value; } }
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public Product(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
