using System;

namespace _2.Animals
{
    abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {                
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miauuu");
        }
    }
}
