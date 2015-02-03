using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList
{
    interface ICircularList<T> : IEnumerable<T>
    {
        int Count();
        void Add(T t);

        void Remove(T t);
        T Next();

        T Current();
    }
}
