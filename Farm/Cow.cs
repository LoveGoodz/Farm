using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age, 20, 200, 50, 15) // MaxProduct 200, Ürün başı fiyat 15
        {
        }

        public override void ProduceProduct()
        {
            if (Age >= 4 && ProducedProduct < MaxProduct)
            {
                ProducedProduct += Math.Max(0, 20 - (Age - 4)); // Yaşa göre süt üretimi
            }

            // Depolama kapasitesi sınırını aşmayalım
            if (ProducedProduct > MaxProduct)
            {
                ProducedProduct = MaxProduct;
            }
        }
    }


}
