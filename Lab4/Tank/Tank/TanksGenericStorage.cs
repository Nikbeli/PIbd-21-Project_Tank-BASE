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
        readonly Dictionary<string, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>> _tankStorages;
        public List<string> Keys => _tankStorages.Keys.ToList();
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;
        public TanksGenericStorage(int pictureWidth, int pictureHeight)
        {
            _tankStorages = new Dictionary<string, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        public void AddSet(string name)
        {
            if (_tankStorages.ContainsKey(name)) return;
            _tankStorages[name] = new TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>(_pictureWidth, _pictureHeight);
        }

        public void DelSet(string name)
        {
            if (!_tankStorages.ContainsKey(name)) return;
            _tankStorages.Remove(name);
        }

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
