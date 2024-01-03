using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using Tank.Entities;
using Tank.MovementStrategy;

namespace Tank
{
    public class DrawArmoVehicle
    {
        public EntityArmoVehicle? Tank { get; protected set; }
        protected int _pictureWidth;
        protected int _pictureHeight;
        protected int _startPosX;
        protected int _startPosY;
        protected readonly int _Width = 160;
        protected readonly int _Height = 90;
        public int GetPosX => _startPosX;
        public int GetPosY => _startPosY;
        public int GetWidth => _Width;
        public int GetHeight => _Height;

        // Конструктор класса
        public DrawArmoVehicle(int speed, double weight, Color bodyColor, int width, int height)
        {
            _pictureHeight = height;
            _pictureWidth = width;
            if (_pictureHeight < _Height || _pictureWidth < _Width)
                return;
            Tank = new EntityArmoVehicle(speed, weight, bodyColor);
        }

        protected DrawArmoVehicle(int speed, double weight, Color bodyColor, int width, int height, int tankWidth, int tankHeight)
        {
            _pictureHeight = height;
            _pictureWidth = width;
            _Height = tankHeight;
            _Width = tankWidth;
            if (_pictureHeight < _Height || _pictureWidth < _Width)
                return;
            Tank = new EntityArmoVehicle(speed, weight, bodyColor);
        }

        public bool CanMove(Direction direction)
        {
            if (Tank == null)
                return false;
            return direction switch
            {
                Direction.Left => _startPosX - Tank.Step > 0,
                Direction.Up => _startPosY - Tank.Step > 0,
                Direction.Right => _startPosX + _Width + Tank.Step < _pictureWidth,
                Direction.Down => _startPosY + _Height + Tank.Step < _pictureHeight,
                _ => false

            };
        }

        public void SetPosition(int x, int y)
        {
            _startPosX = x;
            _startPosY = y;
        }

        public void MoveTransport(Direction direction)
        {
            if (!CanMove(direction) || Tank == null)
                return;
            switch (direction)
            {
                case Direction.Left:
                    {
                        if (_startPosX - Tank.Step > 0)
                        {
                            _startPosX -= (int)Tank.Step;
                        }
                    }
                    break;
                case Direction.Up:
                    {
                        if (_startPosY - Tank.Step > 0)
                        {
                            _startPosY -= (int)Tank.Step;
                        }
                    }
                    break;
                case Direction.Right: 
                    {
                        if (_startPosX + _Width + Tank.Step < _pictureWidth)
                        {
                            _startPosX += (int)Tank.Step;
                        }
                    }
                    break;
                case Direction.Down:
                    {
                        if (_startPosY + Tank.Step + _Height < _pictureHeight)
                        {
                            _startPosY += (int)Tank.Step;
                        }
                    }
                    break;
            }
        }
        
        public virtual void DrawTransport(Graphics g)
        {
            if (Tank == null)
                return;
            Brush BrushRandom = new SolidBrush(Tank?.BodyColor ?? Color.Black);
            
            //Корпус
            Point[] pointsbody = { new Point(_startPosX + 5, _startPosY + 30), new Point(_startPosX + 110, _startPosY + 30),
                new Point(_startPosX + 142, _startPosY + 30), new Point(_startPosX + 120, _startPosY + 45), new Point(_startPosX + 12, _startPosY + 45) };
            g.FillPolygon(BrushRandom, pointsbody);

            // Колеса, катки
            Brush ColorBlack = new SolidBrush(Color.Black);
            g.FillEllipse(ColorBlack, 10 + _startPosX, 42 + _startPosY, 20, 20);
            g.FillEllipse(ColorBlack, 35 + _startPosX, 42 + _startPosY, 20, 20);
            g.FillEllipse(ColorBlack, 60 + _startPosX, 42 + _startPosY, 20, 20);
            g.FillEllipse(ColorBlack, 85 + _startPosX, 42 + _startPosY, 20, 20);
            g.FillEllipse(ColorBlack, 110 + _startPosX, 42 + _startPosY, 20, 20);
        }

        public IMoveableObject GetMoveableObject => new DrawingObjectTank(this);
    }
}