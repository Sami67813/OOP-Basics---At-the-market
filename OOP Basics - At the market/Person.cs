using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics___At_the_market
{
    internal class Person
    {
        private string name;
        private int money;
        private List<string> products = new List<string>();
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
        }
        public string Name
        {
            get { return name; }
            set { if (value == "") throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }
        public int Money
        {
            get { return money; }
            set { if (value < 0) throw new ArgumentException("Money cannot be negative\"");
                money = value;
            }
        }
        public void AddProduct(Product product) 
        {
            if (product.Value <= money)
            {
                products.Add(product.Name);
                money -= product.Value;
                Console.WriteLine(Name + " bought " + product.Name);
            }
            else {
                Console.WriteLine(Name + " can't afford " + product.Name); 
                
            }
        }
            public override string ToString()
        {
            if (products.Count == 0) return Name + " - Nothing bought";
            else
            {
                return Name + " - " + string.Join(", ", products);
            }
        }
               
    }
}
