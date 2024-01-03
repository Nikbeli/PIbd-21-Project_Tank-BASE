using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class DrawingTank
    {
        public EntityTank Tank { get; set; }
        private int _startPosX;
        private int _startPosY;
        private int? _pictureWidth = null;
        private int? _pictureHeight = null;
        private readonly int _TankWidth = 160;
        public readonly int _TankHeight = 90;

        public void Init(int speed, float weight, Color bodyColor, Color additionalColor, int Step, int width, int height, bool bodykit, bool caterpillar, bool tower)
        {
            if (_pictureHeight < _TankHeight || _pictureWidth < _TankWidth)
                return;
            
            _pictureWidth = width;
            _pictureHeight = height;
            Tank = new EntityTank();
            Tank.Init(speed, weight, bodyColor, additionalColor, Step, width, height, bodykit, caterpillar, tower);
        }

        public void SetPosition(int x, int y, int width, int heiht)
        {
            _pictureWidth = width;
            _pictureHeight = heiht;
            if (x >= 0 && x + _TankWidth <= width && y >= 0 && y + _TankHeight <= heiht)
            {
                _startPosX = x;
                _startPosY = y;              
            }
        }

        public void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _TankWidth + Tank.Step < _pictureWidth)
                    {
                        _startPosX += Tank.Step;
                    }
                    break;
                // влево
                case Direction.Left:
                    if (_startPosX - Tank.Step > 0)
                    {
                        _startPosX -= Tank.Step;
                    }
                    break;
                // вверх
                case Direction.Up:
                    if (_startPosY - Tank.Step > 0)
                    {
                        _startPosY -= Tank.Step;
                    }
                    break;
                // вниз
                case Direction.Down:
                    if (_startPosY + _TankHeight + Tank.Step < _pictureHeight)
                    {
                        _startPosY += Tank.Step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            if (_startPosX < 0 || _startPosY < 0 || !_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }
            Pen pen = new(Color.Black);

            // Отрисовка танковых катков
            Brush BrushBlack = new SolidBrush(Color.Black);
            g.FillEllipse(BrushBlack, _startPosX + 113, _startPosY + 41, 11, 11);
            g.FillEllipse(BrushBlack, _startPosX + 13, _startPosY + 40, 11, 11);

            // Гусеница 
            Brush BrushGray = new SolidBrush(Color.DarkGray);
            g.DrawEllipse(pen, _startPosX + 10, _startPosY + 30, 120, 30);

            // Корпус танка
            Point[] pointsbody = { new Point(_startPosX + 5, _startPosY + 30), new Point(_startPosX + 140, _startPosY + 30),
                new Point(_startPosX + 130, _startPosY + 42), new Point(_startPosX + 12, _startPosY + 42) };
            g.FillPolygon(BrushGray, pointsbody);

            Point[] pointtower = { new Point(_startPosX + 52, _startPosY + 30), new Point(_startPosX + 52, _startPosY + 27), new Point(_startPosX + 40, _startPosY + 23),
                new Point(_startPosX + 15, _startPosY + 18), new Point(_startPosX + 15,_startPosY + 15), new Point(_startPosX + 60, _startPosY + 11), new Point(_startPosX + 90, _startPosY + 11),
                new Point(_startPosX + 120, _startPosY + 20), new Point(_startPosX + 100,_startPosY + 25), new Point(_startPosX + 95, _startPosY + 27), new Point(_startPosX + 90, _startPosY + 30)};

            g.FillPolygon(BrushGray, pointtower);

            // Орудие
            g.FillRectangle(BrushGray, _startPosX + 111, _startPosY + 17, 55, 5);

            // Зенитное орудие
            Brush BrushRandom = new SolidBrush(Tank?.AdditionalColor ?? Color.Black);
            Point[] pointgun = { new Point(_startPosX + 44, _startPosY + 13), new Point(_startPosX + 45, _startPosY + 12), new Point(_startPosX + 41, _startPosY + 8), new Point(_startPosX + 41, _startPosY + 7),
                new Point(_startPosX + 42, _startPosY + 5), new Point(_startPosX + 41, _startPosY + 4), new Point(_startPosX + 44, _startPosY + 3), new Point(_startPosX + 50, _startPosY + 3),
                new Point(_startPosX + 52, _startPosY + 5), new Point(_startPosX + 53, _startPosY + 7), new Point(_startPosX + 58, _startPosY + 11)};
            g.FillPolygon(BrushRandom, pointgun);

            g.FillRectangle(BrushRandom, _startPosX + 50, _startPosY + 5, 20, 2);
        }

        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= _TankWidth || _pictureHeight <= _TankHeight)
            {
                _pictureWidth = null;
                _pictureHeight = null;
                return;
            }
            if (_startPosX + _TankWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - _TankWidth;
            }
            if (_startPosY + _TankHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - _TankHeight;
            }
        }
    }
}