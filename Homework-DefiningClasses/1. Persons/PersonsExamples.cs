using System;

namespace _1.Persons
{
    class PersonsExamples
    {
        static void Main()
        {
            Person spiro = new Person("Spiro", 33, "spiro@spiro.name");
            System.Console.WriteLine(spiro);
            Person kiro = new Person("Kiro", 22);
            System.Console.WriteLine(kiro);

            try
            {
                Person miro = new Person("", 44, "miro@miro.name"); 
            }
            catch (ArgumentException aex)
            {
                Console.Error.WriteLine(aex.Message);
            }

            try
            {
                Person miro = new Person("Miro", 101, "miro@miro.name");
            }
            catch (ArgumentException aex)
            {
                Console.Error.WriteLine(aex.Message);
            }

            try
            {
                Person miro = new Person("Miro", 11, "mail");
            }
            catch (ArgumentException aex)
            {
                Console.Error.WriteLine(aex.Message);
            }
        }
    }
}
