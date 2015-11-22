using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery batteryType;
        private double batteryLife;
        private double price;

        public Laptop(string model, string manufacturer, string processor,
            string ram, string graphicsCard, string hdd, string screen,
            Battery batteryType, double batteryLife, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Laptop(string model, double price)
            : this(model, null, null, null, null, null, null, null, 0, price) {}

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("The field name cannot be empty!");
                }

                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("The field manufacturer cannot be empty!");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("The field processor cannot be empty!");
                }

                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("The field ram cannot be empty!");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("The field graphicsCard cannot be empty!");
                }

                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("The field hdd cannot be empty!");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("The field screen cannot be empty!");
                }

                this.screen = value;
            }
        }

        public Battery BatteryType { get; set; }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of batteryLife cannot be negative!");
                }

                this.batteryLife = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of price cannot be negative!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Model - " + this.Model);

            if (this.Manufacturer != null)
            {
                sb.AppendLine("Manufacturer - " + this.Manufacturer);
            }

            if (this.Processor != null)
            {
                sb.AppendLine("Processor - " + this.Processor);
            }

            if (this.Ram != null)
            {
                sb.AppendLine("RAM - " + this.Ram);
            }

            if (this.GraphicsCard != null)
            {
                sb.AppendLine("GraphicsCard - " + this.GraphicsCard);
            }

            if (this.Hdd != null)
            {
                sb.AppendLine("HDD - " + this.Hdd);
            }

            if (this.Screen != null)
            {
                sb.AppendLine("Screen - " + this.Screen);
            }

            if (this.BatteryType != null)
            {
                sb.AppendLine("Battery - " + BatteryType.TypeOfBattery + ", " + BatteryType.NumberOfCells + "-cells, " + BatteryType.Capacity + " mAh");
            }

            if (this.BatteryLife > 0)
            {
                sb.AppendLine("Battery Life - " + this.BatteryLife + " hours");
            }

            sb.AppendLine("Price - " + this.Price + " lv.");

            return sb.ToString();
        }
    }
}
