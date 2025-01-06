using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGenerics.Entities
{
     class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() 
        {
            return Name
                + ", "
                + Price.ToString("f2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error argument is not a Product");
            }
            Product other = obj as Product; // Down Casting
            return Price.CompareTo(other.Price); // Comparando price com outro price
        }
    }
}
