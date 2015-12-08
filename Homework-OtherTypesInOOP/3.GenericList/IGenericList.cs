using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    public interface IGenericList<T> : IEnumerable<T>
    {
        int Capacity { get; }

        int Count { get; }

        T this[int index] { get; set; }

        void Add(T element);

        void RemoveAt(int index);

        void Insert(int index, T element);

        void Clear();

        int FindIndex(T element);

        bool Contains(T element);

        string Version();
    }
}
