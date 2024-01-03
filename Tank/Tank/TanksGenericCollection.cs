using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Tank.DrawningObjects;
using Tank.MovementStrategy;

namespace Tank.Generics
{
    internal class TanksGenericCollection<T, U>
        where T : DrawArmoVehicle
        where U : IMoveableObject
    {
        // Ширина и высота окна прорисовки
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;
        
        // Размеры занимаемого объектом места
        private readonly int _placeSizeWidth = 180;
        private readonly int _placeSizeHeight = 90;
        
        // Набор объектов
        private readonly SetGeneric<T> _collection;

        // Конструктор
        public TanksGenericCollection(int pictureWidth, int pictureHeight)
        {
            int width = pictureWidth / _placeSizeWidth;
            int height = pictureHeight / _placeSizeHeight;
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
            _collection = new SetGeneric<T>(width * height);
        }

        // Перегрузка оператора сложения
        public static bool operator +(TanksGenericCollection<T, U> collect, T? obj)
        {
            if (obj == null)
            {
                return false;
            }
            return (bool)collect?._collection.Insert(obj);
        }

        // Перегрузка оператора вычитания
        public static T? operator -(TanksGenericCollection<T, U> collect, int pos)
        {
            T? obj = collect._collection[pos];
            if (obj != null)
            {
                collect._collection.Remove(pos);
            }
            return obj;
        }

        // Получение объекта IMoveableObject
        public U? GetU(int pos)
        {
            return (U?)_collection[pos]?.GetMoveableObject;
        }

        // Вывод всего набора объектов
        public Bitmap ShowTanks()
        {
            Bitmap bmp = new(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp);
            DrawBackground(gr);
            DrawObjects(gr);
            return bmp;
        }

        // Метод отрисовки фона 
        private void DrawBackground(Graphics g)
        {
            Pen pen = new(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    //Линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j *
                    _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j *
                    _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i *
                _placeSizeWidth, _pictureHeight / _placeSizeHeight * _placeSizeHeight);
            }
        }

        // Метод прорисовки объектов
        private void DrawObjects(Graphics g)
        {
            int width = _pictureWidth / _placeSizeWidth;
            int height = _pictureHeight / _placeSizeHeight;
            int i = 0;
            foreach(var tank in _collection.GetTanks())
            {
                if (tank != null)
                {
                    tank._pictureWidth = _pictureWidth;
                    tank._pictureHeight = _pictureHeight;
                    tank.SetPosition((i % (_pictureWidth / _placeSizeWidth)) * _placeSizeWidth, (i / (_pictureWidth / _placeSizeWidth)) * _placeSizeHeight);
                    tank.DrawTransport(g);
                }
                i++;
            }
        }
    }
}