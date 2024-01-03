using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.DrawningObjects;
using Tank.Entities;

namespace Tank
{
    internal class DrawiningTankEqutables : IEqualityComparer<DrawArmoVehicle?>
    {
        public bool Equals(DrawArmoVehicle? x, DrawArmoVehicle? y)
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
                return false;
            }
            if (x.Tank.Speed != y.Tank.Speed)
            {
                return false;
            }
            if (x.Tank.Weight != y.Tank.Weight)
            {
                return false;
            }
            if (x.Tank.BodyColor != y.Tank.BodyColor)
            {
                return false;
            }  
            if (x is DrawTank && y is DrawTank)
            {
                if (x.Tank as EntityTank == null)
                {
                    throw new ArgumentNullException(nameof(x));
                }
                if (y.Tank as EntityTank == null)
                {
                    throw new ArgumentNullException(nameof(y));
                }
                if ((x.Tank as EntityTank).AdditionalColor != (y.Tank as EntityTank).AdditionalColor)
                {
                    return false;
                }
                if ((x.Tank as EntityTank).BodyKit != (y.Tank as EntityTank).BodyKit)
                {
                    return false;
                }
                if ((x.Tank as EntityTank).Caterpillar != (y.Tank as EntityTank).Caterpillar)
                {
                    return false;
                }
                if ((x.Tank as EntityTank).Tower != (y.Tank as EntityTank).Tower)
                {
                    return false;
                }
            }
            return true;
        }

        public int GetHashCode([DisallowNull] DrawArmoVehicle obj)
        {
            return obj.GetHashCode();
        }
    }
}