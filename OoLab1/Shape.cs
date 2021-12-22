using System;
namespace OoLab1
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract override string ToString();
        public void SayHello()
        {
            Console.WriteLine($"{this.GetType().Name} says hello!");
        }
        public virtual void ScreamHello()
        {
            Console.WriteLine($"{this.GetType().Name.ToUpper()} SCREAMS HELLO!");
        }
    }
}
