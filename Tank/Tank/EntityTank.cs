using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class EntityTank
    {
        public int Speed { get; private set; }
        public float Weight { get; private set; }
        public Color BodyColor { get; private set; }
        public Color AdditionalColor { get; private set; }
        public int Step => Speed * 100 / (int)Weight;

        public bool BodyKit { get; private set; }
        public bool Caterpillar { get; private set; }
        public bool Tower { get; private set; }

        public void Init(int speed, float weight, Color bodyColor, Color additionalcolor, int step, int width, int height, bool bodyKit, bool caterpillar, bool tower)
        {
            Random random = new Random();
            Speed = speed <= 0 ? random.Next(50, 100) : speed;
            Weight = weight <= 0 ? random.Next(30,60) : weight;
            BodyColor = bodyColor;
            AdditionalColor = additionalcolor;
            BodyKit = bodyKit;
            Caterpillar = caterpillar;
            Tower = tower;
        }
    }
}