using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank.MovementStrategy
{
    public class ObjectParameters
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _width;
        private readonly int _height;

        public int LeftBorder => _x; // Левая граница
        public int TopBorder => _y; // Верхняя граница
        public int RightBorder => _width + _x; // Правая граница
        public int DownBorder => _height + _y; // Нижняя граница
        public int ObjectMiddleHorizontal => _x + _width / 2; // Середина по горизонтали
        public int ObjectMiddleVertical => _y + _height / 2; // Середина по вертикали

        public ObjectParameters(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
    }
}
