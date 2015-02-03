using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList
{
    interface ICircularIntList: IEnumerable
    {
        int Count();
        void Add(int i);

        void Remove(int i);
        int Next();

        int Current();
    }
}
