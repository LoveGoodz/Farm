using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Lifespan { get; set; }
        public double ProducedProduct { get; set; }
        public double MaxProduct { get; set; }
        public double Value { get; set; }
        public double ProductPrice { get; set; }

        public Animal(string name, int age, int lifespan, double producedProduct, double maxProduct, double value, double productPrice)
        {
            Name = name;
            Age = age;
            Lifespan = lifespan;
            ProducedProduct = producedProduct;
            MaxProduct = maxProduct;
            Value = value;
            ProductPrice = productPrice;
        }

        public virtual void ProduceProduct()
        {
        }
    }
}
