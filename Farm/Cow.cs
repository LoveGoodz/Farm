using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age, 20, 0, 50, 15)
        {
            // Başlangıçta maksimum süt üretim miktarı belirlenir
            MaxProduct = 20;
        }

        public override void ProduceProduct()
        {
            if (Age >= 4)
            {
                ProducedProduct += Math.Max(0, 20 - (Age - 4));
            }
        }
    }

}
