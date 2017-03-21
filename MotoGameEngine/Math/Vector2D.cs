using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MotoGameEngine
{
    public class Vector2D
    {
        private float _x; float _y;

        public Vector2D(float x, float y) { _x = x; _y = y; }

        public float Y { get => _y; set => _y = value; }

        public float X { get => _x; set => _x = value; }

        public float length()
        {
            return (float)System.Math.Sqrt(_x * _x + _y * _y);
        }

        public void normalize()
        {
            float l = length();
            if (l > 0) // we never want to attempt to divide by 0  
            {
                _x = _x * 1 / l;
                _y = _y * 1 / l;
            }
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1._x + v2._x, v1._y + v2._y);
        }
        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1._x - v2._x, v1._y - v2._y);
        }
        public static Vector2D operator *(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1._x * v2._x, v1._y * v2._y);
        }
        public static Vector2D operator /(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1._x / v2._x, v1._y / v2._y);
        }
        public static Vector2D operator *(Vector2D v1, float scalar) { return new Vector2D(v1._x * scalar, v1._y * scalar); }

        public static Vector2D operator /(Vector2D v1, float scalar) { return new Vector2D(v1._x / scalar, v1._y / scalar); }
    }
}
