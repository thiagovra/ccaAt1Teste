using System;

public class QuadraticEquation
{
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {
        var delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            return null;
        }
        else
        {
            var pos = 1.0;
            var neg = -1.0;
            var result1 = (pos * Math.Sqrt(delta) - b) / (2.0 * a);
            var result2 = (neg * Math.Sqrt(delta) - b) / (2.0 * a);
            return new Tuple<double, double>(result1, result2);
        };
    }

    public static void Main(string[] args)
    {
        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
    }
}