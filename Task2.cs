using System;

class Task2
{
    static void Main()
    {
        Console.Write("Add 3 sides: ");

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        if ((A + B <= C) || (A + C <= B) || (B + C <= A))
        {
            Console.WriteLine("This is no triangle!");
            return;
        }

        int Perimeter = A + B + C;
        Console.WriteLine($"Perimeter: {Perimeter}");

        double p = Perimeter / 2.0;
        double Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        Console.WriteLine($"Area: {Area}");

        if (A == B && B == C)
        {
            Console.WriteLine("This is an equilateral triangle!");
        }
        else if (A == B || B == C || A == C)
        {
            Console.WriteLine("This triangle is isosceles!");
        }
        else
        {
            Console.WriteLine("This is a scalene triangle!");
        }
    }
}
