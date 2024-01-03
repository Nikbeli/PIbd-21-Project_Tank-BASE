using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal class SetGeneric<T> where T : class
    {
        // Массив объектов, которые храним
        private readonly T?[] _places;

        // Количество объектов в массиве
        public int Count => _places.Length;

        // Конструктор
        public SetGeneric(int count)
        {
            _places = new T?[count];
        }

        //Добавление объекта в набор
        public int Insert(T tank)
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
            _places[0] = tank;
            return 0;
        }

        // Добавление объекта в набор на конкретную позицию
        public bool Insert(T tank, int position)
        {
            if (position < 0 || position >= Count)
                return false;
            if (_places[position] == null)
            {
                _places[position] = tank;
                return true;
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
                return false;
            for(int i = index; index > position; i--)
            {
                _places[i] = _places[i - 1]; 
            }
            _places[position] = tank;
            return true;
        }

        // Удаление объекта из набора с конкретной позиции
        public bool Remove(int position)
        {
            if (position < 0 || position >= Count)
                return false;
            _places[position] = null;
            return true;
        }

        // Получение объекта из набора по позиции
        public T? Get(int position)
        {
            if (position < 0 || position >= Count)
                return null;
            return _places[position];
        }
    }
}