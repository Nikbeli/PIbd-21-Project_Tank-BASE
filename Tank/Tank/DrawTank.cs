using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.Entities;

namespace Tank.DrawningObjects
{
    public class DrawTank : DrawArmoVehicle
    {
        public DrawTank(int speed, double weight, Color bodyColor, Color additionalColor, bool bodyKit, bool caterpillar, bool tower, int width, int height) : base(speed, weight, bodyColor, width, height)
        {
            if (Tank != null)
            {
                Tank = new EntityTank(speed, weight, bodyColor, additionalColor, bodyKit, caterpillar, tower);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            if (Tank is not EntityTank ArmoVehicle)
                return;
            base.DrawTransport(g);
            if (ArmoVehicle.BodyKit)
            {
                Brush bodyBrush = new SolidBrush(ArmoVehicle.AdditionalColor);

                // Корпус танка
                Point[] pointtower = { new Point(_startPosX + 52, _startPosY + 30), new Point(_startPosX + 52, _startPosY + 27), new Point(_startPosX + 40, _startPosY + 23),
                new Point(_startPosX + 15, _startPosY + 18), new Point(_startPosX + 15,_startPosY + 15), new Point(_startPosX + 60, _startPosY + 11), new Point(_startPosX + 90, _startPosY + 11),
                new Point(_startPosX + 120, _startPosY + 20), new Point(_startPosX + 100,_startPosY + 25), new Point(_startPosX + 95, _startPosY + 27), new Point(_startPosX + 90, _startPosY + 30)};

                g.FillPolygon(bodyBrush, pointtower);
            }

            if (ArmoVehicle.Caterpillar)
            {
                // Гусеница. Отрисовка танковых катков
                Brush BrushRandom = new SolidBrush(ArmoVehicle?.AdditionalColor ?? Color.Black);
                g.FillRectangle(BrushRandom, 28 + _startPosX, 50 + _startPosY, 10, 3);
                g.FillRectangle(BrushRandom, 53 + _startPosX, 50 + _startPosY, 10, 3);
                g.FillRectangle(BrushRandom, 78 + _startPosX, 50 + _startPosY, 10, 3);
                g.FillRectangle(BrushRandom, 103 + _startPosX, 50 + _startPosY, 10, 3);
            }

            if (ArmoVehicle.Tower)
            {
                // Орудие
                Brush bodyBrush = new SolidBrush(ArmoVehicle.AdditionalColor);
                g.FillRectangle(bodyBrush, _startPosX + 111, _startPosY + 17, 60, 5);

                // Зенитное орудие
                Point[] pointgun = { new Point(_startPosX + 44, _startPosY + 13), new Point(_startPosX + 45, _startPosY + 12), new Point(_startPosX + 41, _startPosY + 8), new Point(_startPosX + 41, _startPosY + 7),
                new Point(_startPosX + 42, _startPosY + 5), new Point(_startPosX + 41, _startPosY + 4), new Point(_startPosX + 44, _startPosY + 3), new Point(_startPosX + 50, _startPosY + 3),
                new Point(_startPosX + 52, _startPosY + 5), new Point(_startPosX + 53, _startPosY + 7), new Point(_startPosX + 58, _startPosY + 11)};
                g.FillPolygon(bodyBrush, pointgun);

                g.FillRectangle(bodyBrush, _startPosX + 50, _startPosY + 5, 20, 2);
            }
        }
    }
}
