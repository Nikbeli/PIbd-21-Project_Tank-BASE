using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.Generics;
using Tank.DrawningObjects;
using Tank.MovementStrategy;

namespace Tank
{
    internal class TanksGenericStorage
    {
        // Словарь
        readonly Dictionary<string, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>> _tankStorages;

        // Возвращение списка названий наборов
        public List<string> Keys => _tankStorages.Keys.ToList();
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;

        // Конструктор
        public TanksGenericStorage(int pictureWidth, int pictureHeight)
        {
            _tankStorages = new Dictionary<string, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        // Добавление набора
        public void AddSet(string name)
        {
            if (_tankStorages.ContainsKey(name)) return;
            _tankStorages[name] = new TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>(_pictureWidth, _pictureHeight);
        }

        // Удаление набора
        public void DelSet(string name)
        {
            if (!_tankStorages.ContainsKey(name)) return;
            _tankStorages.Remove(name);
        }

        // Доступ к набору
        public TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>?
        this[string ind]
        {
            get
            {
                if (_tankStorages.ContainsKey(ind)) return _tankStorages[ind];
                return null;
            }
        }
    }
}