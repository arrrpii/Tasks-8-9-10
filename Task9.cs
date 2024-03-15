using System;

public class QuadraticEq
{
    public double x1 { get; private set; }
    public double x2 { get; private set; }
    public bool IsValid { get; private set; }

    public QuadraticEq(double a, double b, double c, double d)
    {
        if (a == 0)
        {
            IsValid = false;
            return;
        }

        IsValid = true;
        x1 = (-b - Math.Sqrt(d)) / (2 * a);
        x2 = (-b + Math.Sqrt(d)) / (2 * a);
    }
}
public class Program
{
    public static void Main()
    {
        double a, b, c, d;

        do
        {
            Console.Write("Provide some value to a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Provide some value to b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Provide some value to c: ");
            c = double.Parse(Console.ReadLine());
            d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine();

            if (d < 0)
            {
                Console.WriteLine("Discriminant cannot be negative");
            }

        } while (d < 0);

        QuadraticEq equation = new QuadraticEq(a, b, c, d);

        if (!equation.IsValid)
        {
            Console.WriteLine("'a' cannot be 0");
        }
        else
        {
            Console.WriteLine("First root: " + equation.x1);
            Console.WriteLine("Second root: " + equation.x2);
        }
    }
}

