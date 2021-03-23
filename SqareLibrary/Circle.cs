using System;


namespace SqareLibrary
{
    public class Circle : IFigure
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle()
        {
        }
        public double Radius
        {
            get { return radius; } set
            {
                if (value < 0)
                    throw new Exception("Радиус меньше 0");
                else radius = value; } }

        public double GetSquare()
        {
            return Math.PI * (radius * radius);
        }
    }
}
