
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList
{
    class CircularList<T> : ICircularList<T>
    {
        List<T> _itemsList = new List<T>();
        private int _current = 0;
        
        public IEnumerator<T> GetEnumerator()
        {
            return new IteratorT<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count()
        {
            return _itemsList.Count;
        }

        public void Add(T t)
        {
            _itemsList.Add(t);
        }

        public void Remove(T t)
        {
            _itemsList.Remove(t);
        }

        public T Next()
        {
            if (_itemsList.Count ==0) throw new NoFuckingWayException();
            if (_itemsList.Count > _current + 1) _current++;
            else _current = 0;
            return _itemsList[_current];
        }

        public T Current()
        {
            
            if (_itemsList.Count > _current) return _itemsList[_current];
            throw new NoFuckingWayException();
        }

        internal class NoFuckingWayException : Exception
        {
        }
    }

    internal class IteratorT<T> : IEnumerator<T>
    {
        private readonly CircularList<T> _circularList;
        private int _itemsLeft;
        public IteratorT(CircularList<T> circularList)
        {
            _circularList = circularList;
            _itemsLeft = _circularList.Count();
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (_itemsLeft == 0) return false;
            _circularList.Next();
            _itemsLeft--;
            return true;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public T Current
        {
            get { return _circularList.Current(); }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
