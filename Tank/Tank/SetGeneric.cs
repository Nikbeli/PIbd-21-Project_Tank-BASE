using Tank.Exceptions;
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
        // Список объектов, которые храним и их количество
        private readonly List<T?> _places;
        public int Count => _places.Count;

        // Максимальное количество объектов
        private readonly int _maxCount;

        // Сортировка набора объектов
        public void SortSet(IComparer<T?> comparer) => _places.Sort(comparer);

        // Конструктор 
        public SetGeneric(int count)
        {
            _maxCount = count;
            _places = new List<T?>(_maxCount);
        }

        // Добавление объекта в набор
        public bool Insert(T tank, IEqualityComparer<T?>? equal = null)
        {
            return Insert(tank, 0, equal);
        }

        // Добавление на конкретную позицию
        public bool Insert(T tank, int position, IEqualityComparer<T?>? equal = null)
        {
            if (position < 0 || position >= _maxCount)
                throw new TankNotFoundException(position);  // По позиции

            if (Count >= _maxCount)
                throw new TankStorageOverflowException(_maxCount); // Макс количество в коллекции

            if (equal != null && _places.Contains<T>(tank, equal))
                throw new ApplicationException("уже существует");

            _places.Insert(0, tank);
            return true;
        }

        // Удаление объекта из набора с конкретной позиции
        public bool Remove(int position)
        {
            if (position < 0 || position > _maxCount || position >= Count)
                throw new TankNotFoundException(position);

            _places.RemoveAt(position);
            return true;
        }

        // Получение объекта из набора по позиции
        public T? this[int position]
        {
            get
            {
                if (position < 0 || position >= Count)
                    return null;
                return _places[position];
            }
            set
            {
                if (position < 0 || position > _maxCount || Count == _maxCount)
                    return;
                _places[position] = value;
            }
        }

        // Проход по списку
        public IEnumerable<T?> GetTanks(int? maxTanks = null)
        {
            for (int i = 0; i < _places.Count; ++i)
            {
                yield return _places[i];
                if (maxTanks.HasValue && i == maxTanks.Value)
                {
                    yield break;
                }
            }
        }
    }
}