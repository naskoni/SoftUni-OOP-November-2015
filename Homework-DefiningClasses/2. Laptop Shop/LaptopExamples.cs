using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LaptopShop
{
    class LaptopExamples
    {
        static void Main()
        {
            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U",
                "8 GB", "Intel HD Graphics 4400", "128GB SSD",
                "13.3\"(33.78 cm) – 3200 x 1800 (QHD)",
                new Battery(Battery.BatteryType.LiIon, 4, 2550), 4.5, 2259);
            Console.WriteLine(lenovo);

            Laptop acer = new Laptop("Acer Aspire V5", 1699);
            Console.WriteLine(acer);
        }
    }
}
