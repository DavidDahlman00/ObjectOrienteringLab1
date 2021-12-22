using System;
namespace OoLab1
{
    public class Circle : Shape
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = Math.Abs(radius);
        }

        public override double GetArea()
        {
            return Math.Pow(this.radius, 2) * Math.PI;
        }

        public override double GetPerimeter()
        {
            return 2 * this.radius * Math.PI;
        }

        public override string ToString()
        {
            string message = "This is a Circle with side length "
                + $"{this.radius}" + ", area " + $"{this.GetArea()}"
                + " and perimeter " + $"{this.GetPerimeter()}" + ".";
            return message;
        }
    }
}
