using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Chicken : Animal
    {
        public Chicken(string name, int age) : base(name, age, 6, 0, 20, 5)
        {
            MaxProduct = 5;
        }

        public override void ProduceProduct()
        {
            if (Age >= 1)
            {
                ProducedProduct += Math.Max(0, 5 - (Age - 1));
            }
        }
    }

}

