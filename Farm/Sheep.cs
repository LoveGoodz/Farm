using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Sheep : Animal
    {
        public Sheep(string name, int age) : base(name, age, 10, 200, 30, 15) // MaxProduct 200, Ürün başı fiyat 15
        {
        }

        public override void ProduceProduct()
        {
            if (Age >= 2 && ProducedProduct < MaxProduct)
            {
                ProducedProduct += Math.Max(0, 10 - (Age - 2)); // Yaşa göre süt üretimi
            }

            // Depolama kapasitesi sınırını aşmayalım
            if (ProducedProduct > MaxProduct)
            {
                ProducedProduct = MaxProduct;
            }
        }
    }


}
