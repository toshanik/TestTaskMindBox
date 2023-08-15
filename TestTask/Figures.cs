namespace TestTask
{

    public abstract class Figure
    {
        public abstract double Square();
    }

    public class Circle : Figure
    {
        public int r;
        public Circle(int r)
        {
            if (r <= 0)
                throw new ArgumentException("The value of the Circle must be positive");
            this.r = r;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
    public class Triangle : Figure
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("The values of the Triangle must be positive");
            if (a > c)
                c = a;

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Square()
        {
            if (this.IsRectangular())
                return (a * b) / 2;
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (a - p) * (b - p) * (c - p));
        }

        public bool IsRectangular()
        {
            return (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                    || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                    || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
