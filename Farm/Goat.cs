using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Goat : Animal
    {
        public int MilkProductionPerDay { get; private set; } // Günlük süt üretimi

        public Goat()
        {
            Type = "Goat";
            Lifespan = 15;
            MilkProductionPerDay = 12;
        }

        public override void ProduceProduct()
        {
            if (Age >= 4)
            {
                int yearsProducing = Age - 4;
                MilkProductionPerDay = Math.Max(12 - yearsProducing, 0); // Süt üretimi, yaşa bağlı olarak azalır
            }
            else
            {
                MilkProductionPerDay = 0; // Keçi 4 yaşından küçükse süt üretimi yok
            }
        }

        public override int CalculateAnnualProduction()
        {
            return MilkProductionPerDay * 365;
        }
    }
}
