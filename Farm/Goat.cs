using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Goat : Animal
    {
        public Goat(string name, int age) : base(name, age, 14, 0, 40, 15)
        {
            MaxProduct = 15;
        }

        public override void ProduceProduct()
        {
            if (Age >= 3)
            {
                ProducedProduct += Math.Max(0, 15 - (Age - 3));
            }
        }
    }

}
