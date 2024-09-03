using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Sheep : Animal
    {
        public int MilkProductionPerDay { get; private set; } // Günlük süt üretimi

        public Sheep()
        {
            Type = "Sheep";
            Lifespan = 12;
            MilkProductionPerDay = 10;
        }

        public override void ProduceProduct()
        {
            if (Age >= 3)
            {
                int yearsProducing = Age - 3;
                MilkProductionPerDay = Math.Max(12 - yearsProducing, 0); // Süt üretimi, yaşa bağlı olarak azalır
            }
            else
            {
                MilkProductionPerDay = 0; // Koyun 3 yaşından küçükse süt üretimi yok
            }
        }

        public override int CalculateAnnualProduction()
        {
            return MilkProductionPerDay * 365;
        }
    }
}
