using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList    
{
    class CircularIntList : ICircularIntList
    {
        List<int> _integers = new List<int>();
        private int _current = 0;
        public IEnumerator<int> GetEnumerator()
        {
            return new Iterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count()
        {
            return _integers.Count;
        }


        public void Add(int i)
        {
            _integers.Add(i);
        }

        public void Remove(int i)
        {
            _integers.Remove(i);
        }

        public int Next()
        {
            if (_integers.Count > _current+1) _current++;
            else _current = 0;
            return _integers[_current];
        }

        public int Current()
        {
            // if current doesn't exist return lowest possible number
            if (_integers.Count > _current) return _integers[_current];
            return int.MinValue;
        }
    }

    internal class Iterator : IEnumerator<int>
    {
        private readonly CircularIntList _integers;
        private int _numbersLeft;
        
        public Iterator(CircularIntList integers)
        {
            _integers = integers;
            _numbersLeft = _integers.Count();
        }

        public Iterator(object integers)
        {
            // TODO: Complete member initialization
        }

        public void Dispose()
        {
            
        }

        //If MoveNext passes the end of the collection, the enumerator is positioned after the last element in the collection and MoveNext returns false. When the enumerator is at this position, subsequent calls to MoveNext also return false. If the last call to MoveNext returned false, calling Current throws an exception.
        public bool MoveNext()
        {
            if (_numbersLeft == 0) return false;
            _integers.Next();
            _numbersLeft--;
            return true;
        }

        // The Reset method is provided for COM interoperability and does not need to be fully implemented; instead, the implementer can throw a NotSupportedException.
        public void Reset()
        {
            throw new NotSupportedException();
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        //Current returns the same object until either MoveNext or Reset is called. MoveNext sets Current to the next element.
        public int Current
        {
            get { return _integers.Current(); }
        }
    }

       
}


