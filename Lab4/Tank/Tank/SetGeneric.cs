using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal class SetGeneric<T> where T : class
    {
        //private readonly List<T?> _places;
        private readonly Dictionary<int, T?> _places;
        public int Count => _places.Count;

        private readonly int _maxCount;

        public SetGeneric(int count)
        {
            _maxCount = count;
            //_places = new List<T?>(_maxCount);
            _places = new Dictionary<int, T?>(_maxCount);
        }

        public bool Insert(T tank)
        {
            return Insert(tank, 0);
        }
        public bool Insert(T tank, int position)
        {
            if (position < 0 || position >= _maxCount)
                return false;

            if (Count >= _maxCount)
                return false;
            //_places.Insert(0, tank);
            _places.Add(position, tank);
            return true;
        }

        public bool Remove(int position)
        {
            if (position < 0 || position > _maxCount)
                return false;
            if (position >= Count)
                return false;
            //_places.RemoveAt(position);
            _places.Remove(position);
            return true;
        }

        public T? this[int position]
        {
            get
            {
                if (position < 0 || position > _maxCount)
                    return null;
                return _places[position];
            }
            set
            {
                if (position < 0 || position > _maxCount)
                    return;
                _places[position] = value;
            }
        }


        public IEnumerable<T?> GetTanks(int? maxCars = null)
        {
            for (int i = 0; i < _places.Count; ++i)
            {
                yield return _places[i];
                if (maxCars.HasValue && i == maxCars.Value)
                {
                    yield break;
                }
            }
        }

    }
}