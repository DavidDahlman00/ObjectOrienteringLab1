using System;

namespace OoLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(2);
            Console.WriteLine(square);
            square.sideLength = 10;
            Console.WriteLine(square);
            square.SayHello();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(2, 4);
            Console.WriteLine(rectangle);
            rectangle.SayHello();

            Console.WriteLine();

            Rectangle rectangleWithEqualSides = new Rectangle(2);
            Console.WriteLine(rectangleWithEqualSides);

            Console.WriteLine();

            Circle circle = new Circle(5);
            Console.WriteLine(circle);
            circle.SayHello();

        }
    }
}
