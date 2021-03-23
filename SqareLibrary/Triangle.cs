using System;


namespace SqareLibrary
{
    public class Triangle : IFigure
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        public Triangle(double side1, double side2, double side3) {
            Side_1 = side1;
            Side_2 = side2;
            Side_3 = side3;
        }
     

        public double Side_1 { get { return firstSide; } 
            set { if (value > 0) { firstSide = value; }
                else throw new Exception("Сторона не может быть отрицательной");
            } }
        public double Side_2
        {
            get { return secondSide; }
            set
            {
                if (value > 0) { secondSide = value; }
                else throw new Exception("Сторона не может быть отрицательной");
            }
        }
        public double Side_3
        {
            get { return thirdSide; }
            set
            {
                if (value > 0) { thirdSide = value; }
                else throw new Exception("Сторона не может быть отрицательной");
            }
        }
        private double halfPerimetr {
            get { return (firstSide + secondSide + thirdSide) / 2; }
            set { }
        }
        public double GetSquare()
        {
            return Math.Sqrt(halfPerimetr * (halfPerimetr - firstSide) * (halfPerimetr - secondSide)
                * (halfPerimetr - thirdSide));
        }
        public bool IsRectangular()
        {
            double[] sides= new[] { firstSide, secondSide, thirdSide};
            Array.Sort(sides);
            if (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1])
            {
                return true;
            }
            else return false;
            
        }
    }
}
