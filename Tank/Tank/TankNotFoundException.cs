using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Tank.Exceptions
{
    [Serializable]
    internal class TankNotFoundException : ApplicationException
    {
        public TankNotFoundException(int i) : base($"Не найден объект по позиции {i}") { }
        public TankNotFoundException() : base() { }
        public TankNotFoundException(string message) : base(message) { }
        public TankNotFoundException(string message, Exception exception) : base(message, exception) { }
        protected TankNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}