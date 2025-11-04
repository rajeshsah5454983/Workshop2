

class Circle
{
    public const double PI = 3.14;

    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }


    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {

        Circle c = new Circle();

        double radius = 5;
        Console.WriteLine($"For a circle with radius {radius}:");
        Console.WriteLine($"Area = {c.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter = {c.CalculatePerimeter(radius)}");
    }
}