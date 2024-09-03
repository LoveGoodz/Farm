using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Chicken : Animal
    {
        public int EggProductionPerYear { get; private set; } // Yıllık yumurta üretimi

        public Chicken()
        {
            Type = "Chicken";
            Lifespan = 8; 
            EggProductionPerYear = 300;
        }

        public override void ProduceProduct()
        {
            if (Age >= 2)
            {
                int yearsProducing = Age - 2;
                EggProductionPerYear = Math.Max(300 - (yearsProducing * 30), 0); // Yumurta üretimi, yaşa bağlı olarak azalır
            }
            else
            {
                EggProductionPerYear = 0; // Tavuk 2 yaşından küçükse yumurta üretimi yok
            }
        }

        public override int CalculateAnnualProduction()
        {
            return EggProductionPerYear; // Yıllık yumurta üretimi
        }
    }

}
