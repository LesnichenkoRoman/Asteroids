using System;

namespace _Asteroids.Features.Figures
{
    public struct Vector2
    {
        private float x;
        public float y;
        public float Length => (float) Math.Sqrt(x * x + y * y);
        
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Normalize()
        {
            var length = Length;
            
            x = x / length;
            y = y / length;
            
            return this;
        }
        
        public static Vector2 operator *(Vector2 a, float b) { return new Vector2 { x = a.x * b, y = a.y * b }; }
        public static Vector2 operator /(Vector2 a, float b) { return new Vector2 { x = a.x / b, y = a.y / b }; }
        public static Vector2 operator +(Vector2 a, Vector2 b) { return new Vector2 { x = a.x + b.x, y = a.y + b.y }; }
        public static Vector2 operator -(Vector2 a, Vector2 b) { return new Vector2 { x = a.x - b.x, y = a.y - b.y }; }
    }
}