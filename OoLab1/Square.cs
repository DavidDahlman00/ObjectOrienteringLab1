using System;
namespace OoLab1
{
    public class Square : Shape
    {
        public double sideLength;
        

        public Square(double sideLength)
        {
            this.sideLength = Math.Abs(sideLength);
        }

        public override double GetArea()
        {
        return Math.Pow(this.sideLength, 2);
        }

        public override double GetPerimeter()
        {
            return 4 * this.sideLength;
        }

        public override string ToString()
        {
            string message = "This is a Square with side length "
                + $"{this.sideLength}" + ", area " + $"{this.GetArea()}"
                + " and perimeter " + $"{this.GetPerimeter()}" + ".";
            return message;
        }
    }
}
