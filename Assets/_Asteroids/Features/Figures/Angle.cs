using System;

namespace _Asteroids.Features.Figures
{
    public struct Angle
    {
        private float _value;

        public float value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                Normalize();
            }
        }

        public Vector2 Vector => AngleToVector2(this);
        
        public Angle(float value)
        {
            _value = value;
            Normalize();
        }

        public Angle Normalize()
        {
            value %= 360;
            if (value < 0) value += 360;
            return this;
        }

        public static Vector2 AngleToVector2(Angle angle)
        {
            var x = (float) Math.Cos(angle.value);
            var y = (float) Math.Sin(angle.value);
            return new Vector2(x, y);
        }
    }
}