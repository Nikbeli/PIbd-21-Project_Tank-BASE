using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.MovementStrategy
{
    public class MoveToBorder : AbstractStrategy
    {
        protected override bool IsTargetDestination()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return false;
            }
            return objParams.RightBorder + GetStep() >= FieldWidth && objParams.DownBorder + GetStep() >= FieldHeight;
        }
        protected override void MoveToTarget()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return;
            }
            var diffX = objParams.RightBorder - FieldWidth;
            var diffY = objParams.DownBorder - FieldHeight;
            if (diffX >= 0)
            {
                MoveDown();
            }
            else if (diffY >= 0)
            {
                MoveRight();
            }
            else if (Math.Abs(diffX) > Math.Abs(diffY))
            {
                MoveRight();
            }
            else
            {
                MoveDown();
            }
        }
    }
}