using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.MovementStrategy
{
    public abstract class AbstractStrategy
    {
        private IMoveableObject? _moveableObject;
        private Status _state = Status.NotInit;
        protected int FieldWidth { get; private set; }
        protected int FieldHeight { get; private set; }

        public Status GetStatus() { return _state; }

        public void SetData(IMoveableObject moveableObject, int width, int height)
        {
            if (moveableObject == null)
            {
                _state = Status.NotInit;
                return;
            }
            _state = Status.InProgress;
            _moveableObject = moveableObject;
            FieldHeight = height;
            FieldWidth = width;
        }

        public void MakeStep()
        {
            if (_state != Status.InProgress)
                return;
            if (IsTargetDestination())
            {
                _state = Status.Finish;
                return;
            }
            MoveToTarget();
        }

        protected bool MoveLeft() => MoveTo(Direction.Left);
        protected bool MoveRight() => MoveTo(Direction.Right);
        protected bool MoveUp() => MoveTo(Direction.Up);
        protected bool MoveDown() => MoveTo(Direction.Down);
        protected ObjectParameters? GetObjectParameters => _moveableObject?.GetObjectParameters;

        protected int? GetStep()
        {
            if (_state != Status.InProgress)
            {
                return null;
            }
            return _moveableObject?.GetStep;
        }
        protected abstract void MoveToTarget();

        protected abstract bool IsTargetDestination();

        private bool MoveTo(Direction direction)
        {
            if (_state != Status.InProgress)
                return false;
            if (_moveableObject?.CheckCanMove(direction) ?? false)
            {
                _moveableObject.MoveObject(direction);
                return true;
            }
            return false;
        }
    }
}
