using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PcCatalog
{
    class PcCatalogExamples
    {
        static void Main()
        {
            Component videoCardAMDR9 = new Component("Video Card AMD R9 280", "3GB, Sapphire Dual-X OC with Boost, PCI-E 3.0, DDR5, 384bit, HDMI, 2xDVI, DisplayPort", 367.04M);
            Component videoCardGeForce = new Component("Video Card GeForce GT 740", "2GB, PALIT Video Card, PCI-E 3.0 x16, DDR3, 128bit, HDMI, DualDVI, VGA, Retail", 196.83M);
            Component hddWD = new Component("HDD 1TB WD Caviar", "SATA 6Gb/s, 7200rpm, 64MB, 3.5", 107.98M);
            Component hddToshiba = new Component("HDD 1TB Toshiba", 102.61M);
            Component ramAData = new Component("RAM A-Data 4 GB", 43.22M);
            Component mainboardAsus = new Component("Mainboard Asus H81M-C", "H81, LGA1150, DDR3, PCI-E (DVI), SB7.1, Lan1000, 2x SATA 6Gb/s, 2xUSB3.0, mATX", 104.56M);
            Component cpuIntel = new Component("CPU Intel Haswell Core i3 4170", "3.7GHz, 3MB L3, 350MHz-1.15GHz GPU, LGA1150", 258.44M);
            Component keyboardHama = new Component("Keyboard Hama SE3000", 33.26M);
            Component mouseGenius = new Component("Mouse Genius 1200 dpi", 43.85M);

            List<Computer> computers = new List<Computer>()
            {
                new Computer("Lenovo", cpuIntel, mainboardAsus, videoCardGeForce, hddWD, ramAData, keyboardHama, mouseGenius),
                new Computer("Dell", cpuIntel, mainboardAsus, videoCardAMDR9, hddToshiba, ramAData, keyboardHama, mouseGenius),
                new Computer("Jar Computers", cpuIntel, mainboardAsus, videoCardGeForce, hddWD, ramAData),
                new Computer("HP", cpuIntel, mainboardAsus),                
            };

            computers.OrderBy(c => c.Price).ToList().ForEach(Console.WriteLine);
        }
    }
}
