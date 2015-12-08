using System;
using _3.GenericList;

namespace _4.GenericListVersion
{
    class GenericListVersionExample
    {
        static void Main()
        {
            IGenericList<decimal> decimals = new GenericList<decimal>();
            decimals.Add(0.0001m);
            Console.WriteLine(decimals);
            Console.WriteLine(decimals.Version());
        }
    }
}
