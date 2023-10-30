using System;
using System.Diagnostics;

namespace CalculatePi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius = 10000;
            Console.WriteLine("Radius: " + radius);

            int squareRadius = radius * radius;

            Stopwatch sw = Stopwatch.StartNew();

            int deltaXSquared = 0;

            int circleArea = 0;
            for (int i = 1; i < radius; i++)
            {
                deltaXSquared += 2 * i - 1;

                int deltaYSquared = (radius + 1) * (radius + 1);
                for (int j = radius; j >= 0; j--)
                {
                    deltaYSquared += -2 * j - 1;
                    double distance = deltaXSquared + deltaYSquared;
                    if (distance < squareRadius)
                    {
                        circleArea += j + 1;
                        Console.WriteLine(j);
                        break;
                    }
                }
            }

            circleArea *= 4;

            Console.WriteLine("Pi:" + circleArea / (double)(squareRadius));

            sw.Stop();
            Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds}ms");
        }
    }
}
