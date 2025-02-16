using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal class SetGeneric<T> where T : class
    {
        private readonly T?[] _places;

        public int Count => _places.Length;

        public SetGeneric(int count)
        {
            _places = new T?[count];
        }

        public int Insert(T car)
        {
            int index = -1;
            for(int i = 0; i < _places.Length; i++)
            {
                if (_places[i] == null)
                {
                    index = i; break;
                }
            }
            if (index < 0)
            {
                return -1;
            }
            for(int i = index; i > 0; i--)
            {
                _places[i] = _places[i - 1];
            }
            _places[0] = car;
            return 0;
        }

        public int Insert(T car, int position)
        {
            if (position < 0 || position >= Count)
                return -1;
            if (_places[position] == null)
            {
                _places[position] = car;
                return position;
            }
            int index = -1;
            for(int i = position; i < Count; i++)
            {
                if (_places[i] == null)
                {
                    index = i; break;
                }
            }
            if (index < 0)
                return -1;
            for(int i = index; index > position; i--)
            {
                _places[i] = _places[i - 1]; 
            }
            _places[position] = car;
            return position;
        }

        public bool Remove(int position)
        {
            if (position < 0 || position >= Count)
                return false;
            _places[position] = null;
            return true;
        }

        public T? Get(int position)
        {
            if (position < 0 || position >= Count)
                return null;
            return _places[position];
        }
    }
}
