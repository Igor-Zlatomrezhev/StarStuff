using System;

namespace AreaComputer
{
    public interface IFigure
    {
        double Area { get; }
    }

    public sealed class Circle : IFigure
    {
        private double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius of the circle cannot be less or equal to zero.");

            this.Radius = radius;
        }
    }

    public sealed class Triangle : IFigure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public double Area
        {
            get
            {
                double S = (A + B + C) / 2;
                double temp = S * (S - A) * (S - B) * (S - C);

                if (temp <= 0)
                    throw new ArgumentException("Impossible values of the provided sides.");

                return Math.Sqrt(temp);
            }
        }

        public bool IsRectangular
        {
            get
            {
                double x1 = A * A;
                double x2 = B * B;
                double x3 = C * C;

                double accuracy = 0.001;

                return (Math.Abs(x1 + x2 - x3) < accuracy) ||
                       (Math.Abs(x1 + x3 - x2) < accuracy) ||
                       (Math.Abs(x2 + x3 - x1) < accuracy);
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("The side of the triangle cannot be less or equal to zero.");

            this.A = a;
            this.B = b;
            this.C = c;
        }
    }
}
