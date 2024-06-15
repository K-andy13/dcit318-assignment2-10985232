public abstract class Shape
{
    public abstract double GetArea();

    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }


    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
    static void Main()
    {
        #region Abstract Classes and Methods
        Shape myCircle = new Circle(5.0);
        Console.WriteLine("Area of the circle: " + myCircle.GetArea());

        Shape myRectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine("Area of the rectangle: " + myRectangle.GetArea());
    }


