using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.DrawningObjects;

namespace Tank.MovementStrategy
{
    public class DrawingObjectTank : IMoveableObject
    {
        private readonly DrawArmoVehicle? _drawTank = null;
        public DrawingObjectTank(DrawArmoVehicle drawTank)
        {
            _drawTank = drawTank;
        }

        public ObjectParameters? GetObjectParameters
        {
            get
            {
                if (_drawTank == null  || _drawTank.Tank == null)
                    return null;
                return new ObjectParameters(_drawTank.GetPosX, _drawTank.GetPosY, _drawTank.GetWidth, _drawTank.GetHeight);
            }
        }
        public int GetStep => (int)(_drawTank?.Tank?.Step ?? 0);
        public bool CheckCanMove(Direction direction) => _drawTank?.CanMove(direction) ?? false;
        public void MoveObject(Direction direction) => _drawTank?.MoveTransport(direction);
    }
}
