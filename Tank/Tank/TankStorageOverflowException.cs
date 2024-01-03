using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Tank
{
    [Serializable]
    internal class TankStorageOverflowException : ApplicationException
    {
        public TankStorageOverflowException(int count) : base($"В наборе превышено допустимое количество: {count}") { }
        public TankStorageOverflowException() : base() { }
        public TankStorageOverflowException(string message) : base(message) { }
        public TankStorageOverflowException(string message, Exception exception) : base(message, exception) { }
        protected TankStorageOverflowException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}