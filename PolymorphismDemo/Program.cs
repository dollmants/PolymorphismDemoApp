using System;

namespace PolymorphismDemo
{
    /// <summary>
    /// Shape is the base class from which other classes can extend.
    /// </summary>
    class Shape
    {
        protected int width, height;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="a">The parameter used to assign width.</param>
        /// <param name="b">The parameter used to assign height.</param>
        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        /// <summary>
        /// This method is virtual so that other classes can Override it.
        /// </summary>
        /// <returns></returns>
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }

    /// <summary>
    /// The Rectangle class extends the Shape class.
    /// </summary>
    class Rectangle : Shape
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="a">The parameter used to assign width, in the base class.</param>
        /// <param name="b">The parameter used to assign height, in the base class.</param>
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }

        /// <summary>
        /// Overrides the base class area method.
        /// </summary>
        /// <returns>Area, calculated by multiplying width times height.</returns>
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }

    /// <summary>
    /// The Triangle class extends the Shape class.
    /// </summary>
    class Triangle : Shape
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="a">The parameter used to assign width, in the base class.</param>
        /// <param name="b">The parameter used to assign height, in the base class.</param>
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {

        }

        /// <summary>
        /// Overrides the base class area method.
        /// </summary>
        /// <returns>Area, calculated by multiplying width times height and dividing the result by two.</returns>
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }

    /// <summary>
    /// The Caller class contains a method which implements Dynamic Polymorphism.
    /// </summary>
    class Caller
    {
        /// <summary>
        /// Implements Dynamic Polymorphism.
        /// </summary>
        /// <param name="sh">The shape object which calculates the area based on the type of shape,
        /// (i.e. if the shape is a Triangle, the area() method in the Triangle class will be called).</param>
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }

    class Tester
    {
        /// <summary>
        /// The Main program used to "Test" the code.
        /// </summary>
        /// <param name="args">string arguments.</param>
        static void Main(string[] args)
        {
            //Create a new Caller object.
            Caller c = new Caller();
            //Create a new Rectangle object.
            Rectangle r = new Rectangle(10, 7);
            //Create a new Triangle object.
            Triangle t = new Triangle(10, 5);
            //Calculate area for the rectangle.
            c.CallArea(r);
            //Calculate area for the triangle
            c.CallArea(t);
            //Prompt the user.
            Console.WriteLine("Press any key to end the program.");
            //Takes an input from the user and allows the program to end.
            Console.ReadKey();
        }
    }
}
