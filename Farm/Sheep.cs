using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Sheep : Animal
    {
        public Sheep(string name, int age) : base(name, age, 10, 0, 30, 15)
        {
            MaxProduct = 10;
        }

        public override void ProduceProduct()
        {
            if (Age >= 2)
            {
                ProducedProduct += Math.Max(0, 10 - (Age - 2));
            }
        }
    }

}
