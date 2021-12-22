using System;
namespace OoLab1
{
    public class Rectangle : Shape
    {
        public double height;
        public double width;
        public double sideLength;

        public Rectangle( double width, double height)
        {
            this.height = Math.Abs(height);
            this.width = Math.Abs(width);
            this.sideLength = -1;
        }

        public Rectangle(double sideLength)
        {
            this.height = Math.Abs(sideLength);
            this.width = Math.Abs(sideLength);
            this.sideLength = Math.Abs(sideLength);
        }

        public override double GetArea()
        {
            return this.height * this.width;
        }

        public override double GetPerimeter()
        {
            return 2 * this.height + 2 * this.width;
        }

        public override string ToString()
        {
            if(this.sideLength == -1)   //Selects witch constructor to use.
            {
                string message = "This is a Rectangle with height "
                                + $"{this.height}" + ", width " + $"{this.width}"
                                + ". Area " + $"{this.GetArea()}"
                                + " and perimeter " + $"{this.GetPerimeter()}" + ".";
                return message;
            }
            else
            {
                string message = "This is a Rectangle with height "
                                + $"{this.sideLength}" + ", width " + $"{this.sideLength}"
                                + ". Area " + $"{this.GetArea()}"
                                + " and perimeter " + $"{this.GetPerimeter()}" + ".";
                return message;
            }
            
        }
    }
}
