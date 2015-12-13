using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.StudentClass
{
    class PropertyChangedEventArgs : EventArgs
    {
        private string propertyName;
        private dynamic oldValue;
        private dynamic newValue;

        public PropertyChangedEventArgs(string propertyName, dynamic oldValue, dynamic newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; private set; }

        public dynamic OldValue { get; private set; }

        public dynamic NewValue { get; private set; }
    }
}
