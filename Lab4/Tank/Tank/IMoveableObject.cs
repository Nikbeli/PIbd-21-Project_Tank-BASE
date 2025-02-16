using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.MovementStrategy
{
    public interface IMoveableObject
    {
        ObjectParameters? GetObjectParameters { get; }
        int GetStep { get; }
        bool CheckCanMove(Direction direction);
        void MoveObject(Direction direction);
    }
}
