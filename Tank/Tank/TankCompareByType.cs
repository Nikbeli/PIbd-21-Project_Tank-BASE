using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.DrawningObjects;

namespace Tank
{
    internal class TankCompareByType : IComparer<DrawArmoVehicle?>
    {
        public int Compare(DrawArmoVehicle? x, DrawArmoVehicle? y)
        {
            if (x == null || x.Tank == null)
            {
                throw new ArgumentNullException(nameof(x));
            }
            if (y == null || y.Tank == null)
            {
                throw new ArgumentNullException(nameof(y));
            }
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            var speedCompare = x.Tank.Speed.CompareTo(y.Tank.Speed);
            if (speedCompare != 0)
            {
                return speedCompare;
            }
            return x.Tank.Weight.CompareTo(y.Tank.Weight);
        }
    }
}