using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Sheep : Animal
    {
        public Sheep(string name, int age) : base(name, age, 10, 0, 80, 30, 15)
        {
        }

        public override void ProduceProduct()
        {
            if (Age >= 2)
            {
                double dailyProduction = 10 - (Age - 2);
                ProducedProduct += dailyProduction;
                if (ProducedProduct > MaxProduct)
                    ProducedProduct = MaxProduct;
            }
        }
    }
}
