using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Goat : Animal
    {
        public Goat(string name, int age) : base(name, age, 14, 200, 40, 15) // MaxProduct 200, Ürün başı fiyat 15
        {
        }

        public override void ProduceProduct()
        {
            if (Age >= 3 && ProducedProduct < MaxProduct)
            {
                ProducedProduct += Math.Max(0, 15 - (Age - 3)); // Yaşa göre süt üretimi
            }

            // Depolama kapasitesi sınırını aşmayalım
            if (ProducedProduct > MaxProduct)
            {
                ProducedProduct = MaxProduct;
            }
        }
    }


}
