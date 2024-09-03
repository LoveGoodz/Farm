using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Cow : Animal
    {
        public int MilkProductionPerDay { get; private set; } // Günlük süt üretimi

        public Cow()
        {
            Type = "Cow";
            Lifespan = 20;
            MilkProductionPerDay = 16; 
        }

        public override void ProduceProduct()
        {
            if (Age >= 5)
            {
                int yearsProducing = Age - 5;
                MilkProductionPerDay = Math.Max(16 - yearsProducing, 0); // Süt üretimi, yaşa bağlı olarak azalır
            }
            else
            {
                MilkProductionPerDay = 0; // İnek 5 yaşından küçükse süt üretimi yok
            }
        }

        public override int CalculateAnnualProduction()
        {
            return MilkProductionPerDay * 365;
        }
    }

}
