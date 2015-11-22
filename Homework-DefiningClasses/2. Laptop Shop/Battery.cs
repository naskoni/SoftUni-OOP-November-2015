using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LaptopShop
{
    class Battery
    {
        private BatteryType batteryType;
        private int numberOfCells;
        private int capacity;

        public Battery(BatteryType batteryType, int numberOfCells, int capacity)
        {
            this.TypeOfBattery = batteryType;
            this.NumberOfCells = numberOfCells;
            this.Capacity = capacity;
        }



        public BatteryType TypeOfBattery { get; set; }

        public int NumberOfCells
        {
            get
            {
                return this.numberOfCells;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of cells must be > 0");
                }

                this.numberOfCells = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery capacity must be > 0");
                }

                this.capacity = value;
            }
        }

        public enum BatteryType
        {
            NiMh,
            LiIon,
            LiPo
        }
    }
}
