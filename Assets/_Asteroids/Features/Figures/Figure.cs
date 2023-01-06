namespace _Asteroids.Features.Figures
{
    public class Figure
    {
        public Vector2 position;
        public Angle angle;

        public Figure(Vector2 position, Angle angle)
        {
            this.position = position;
            this.angle = angle;
        }
    }
}