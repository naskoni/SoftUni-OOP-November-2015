using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PcCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

        public Computer(string name, params Component[] components)
        {
            this.Name = name;
            this.AddComponents(components);
        }        

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("The field name cannot be empty");
                }
                this.name = value;
            }
        }

        private void AddComponents(Component[] components)
        {
            this.components = new List<Component>();

            foreach (var component in components)
            {
                this.components.Add(component);
            }
        }

        public decimal Price
        {
            get
            {
                return this.components.Sum(c => c.Price);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*', 33));
            sb.AppendLine("PC name - " + this.Name);

            foreach (var component in this.components)
            {
                sb.AppendLine(component.ToString());
            }

            sb.AppendLine("Total price - " + this.Price);

            return sb.ToString();
        }
    }
}
