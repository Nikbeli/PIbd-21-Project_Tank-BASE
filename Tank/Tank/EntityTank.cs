using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.Entities
{
    public class EntityTank : EntityArmoVehicle
    {
        public Color AdditionalColor { get; private set; }
        public bool BodyKit { get; private set; }
        public bool Caterpillar { get; private set; }
        public bool Tower { get; private set; }
        public EntityTank(int speed, double weight, Color bodyColor, Color additionalColor, bool bodyKit, bool caterpillar, bool tower) : base(speed, weight, bodyColor)
        {
            AdditionalColor = additionalColor;
            BodyKit = bodyKit;
            Caterpillar = caterpillar;
            Tower = tower;
        }
    }
}