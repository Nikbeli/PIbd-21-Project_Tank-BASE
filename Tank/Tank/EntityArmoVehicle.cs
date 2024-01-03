using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class EntityArmoVehicle
    {
        public int Speed { get; private set; }
        public double Weight { get; private set; }
        public Color BodyColor { get; private set; }
        public void setBodyColor(Color color) { BodyColor = color; }
        public double Step => (double)Speed * 100 / Weight;
        public EntityArmoVehicle(int speed, double weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
        }
    }
}