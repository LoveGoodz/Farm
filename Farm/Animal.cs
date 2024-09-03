using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public abstract class Animal
    {
        public int Age { get; set; } 
        public string Type { get; set; } 
        public int Lifespan { get; set; } 

        // Ürün üretim hesaplamasını her hayvan için özelleştirilmiş olarak yapacak metod
        public abstract void ProduceProduct();

        // Yıllık üretimi hesaplayacak metod
        public abstract int CalculateAnnualProduction();
    }


}
