using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Chicken : Animal
    {
        public Chicken(string name, int age) : base(name, age, 6, 50, 20, 5) // MaxProduct 50, Ürün başı fiyat 5
        {
        }

        public override void ProduceProduct()
        {
            if (ProducedProduct < MaxProduct)
            {
                ProducedProduct += 5; // Her gün 5 yumurta üretilecek (10 saniyede bir)
            }

            // Depolama kapasitesi sınırını aşmayalım
            if (ProducedProduct > MaxProduct)
            {
                ProducedProduct = MaxProduct;
            }
        }
    }


}

