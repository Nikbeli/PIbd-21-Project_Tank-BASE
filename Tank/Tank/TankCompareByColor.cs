using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.DrawningObjects;
using Tank.Entities;

namespace Tank
{
    internal class TankCompareByColor : IComparer<DrawArmoVehicle?>
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
            if (x.Tank.BodyColor != y.Tank.BodyColor)
            {
                return x.Tank.BodyColor.Name.CompareTo(y.Tank.BodyColor.Name);
            }
            if (x.GetType() == y.GetType() && x is DrawTank)
            {
                return (x.Tank as EntityTank).AdditionalColor.Name.CompareTo((y.Tank as EntityTank).AdditionalColor.Name);
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