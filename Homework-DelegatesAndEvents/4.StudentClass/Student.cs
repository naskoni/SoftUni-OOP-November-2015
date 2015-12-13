using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.StudentClass
{
    class Student
    {
        private string name;
        private int age;

        public delegate void PropertyChangedEventHandler(
            object obj, PropertyChangedEventArgs args);
        public event PropertyChangedEventHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != this.name)
                {
                    FirePropertyChangedEvent(nameof(Name), this.name, value);
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value != this.age)
                {
                    FirePropertyChangedEvent(nameof(Age), this.age, value);
                    this.age = value;
                }
            }
        }

        private void FirePropertyChangedEvent(string nameOfProperty, dynamic oldValue, dynamic newValue)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameOfProperty, oldValue, newValue));
            }
        }

        

        
    }
}
