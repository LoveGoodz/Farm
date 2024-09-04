using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Chicken : Animal
    {
        public Chicken(string name, int age) : base(name, age, 6, 0, 20, 20, 5)
        {
        }

        public override void ProduceProduct()
        {
            if (Age >= 1)
            {
                double dailyProduction = 5 - (Age - 1);
                ProducedProduct += dailyProduction;
                if (ProducedProduct > MaxProduct)
                    ProducedProduct = MaxProduct;
            }
        }
    }
}

