using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace OOP_Basics___At_the_market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            string[] productTypes = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person>people = new List<Person>();
            List<Product>productValues = new List<Product>();
            //List<string>order = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                string[] nameMoney = names[i].Split("=");
                people.Add(new Person(nameMoney[0], int.Parse(nameMoney[1])));
            }
            for (int i = 0; i < productTypes.Length; i++)
            {
                string[] nameValue = productTypes[i].Split("=");
                productValues.Add(new Product(nameValue[0], int.Parse(nameValue[1])));
            }
            
            while (true)
            {
                int nameIndex = 0;
                int productIndex = 0;
                string command = Console.ReadLine();
                if(command == "END") { break; }
                string[] nameProduct = command.Split(" ");
                for(int i = 0; i < names.Length; i++)
                {
                  if (nameProduct[0] == people[i].Name )
                    {
                        nameIndex = i;
                    }
                }
               for (int i = 0; i < productTypes.Length; i++)
               {
                 if (nameProduct[1] == productValues[i].Name)
                    {
                     productIndex = i;
                    }
               }
                people[nameIndex].AddProduct(productValues[productIndex]);
            }
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
