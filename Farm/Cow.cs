using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age, 20, 0, 80, 50, 15)
        {
        }

        public override void ProduceProduct()
        {
            if (Age >= 4)
            {
                double dailyProduction = 20 - (Age - 4);
                ProducedProduct += dailyProduction;
                if (ProducedProduct > MaxProduct)
                    ProducedProduct = MaxProduct;
            }
        }
    }
}
