using System;

namespace pz1
{
    class Task2 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Введіть три сторони трикутника:");
            double a, b, c;

            while (true)
            {
                Console.Write("Сторона a: ");
                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Некоректне значення. Введіть додатне число.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Сторона b: ");
                if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Некоректне значення. Введіть додатне число.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Сторона c: ");
                if (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.WriteLine("Некоректне значення. Введіть додатне число.");
                    continue;
                }
                break;
            }

            if (IsTriangleValid(a, b, c))
            {
                double perimeter = CalculatePerimeter(a, b, c);
                double area = CalculateArea(a, b, c);
                string triangleType = DetermineTriangleType(a, b, c);

                Console.WriteLine($"Периметр: {perimeter:F2}");
                Console.WriteLine($"Площа: {area:F2}");
                Console.WriteLine($"Тип трикутника: {triangleType}");
            }
            else
            {
                Console.WriteLine("Трикутник не існує!");
            }
        }

        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        private double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        private string DetermineTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Рівносторонній";
            if (a == b || b == c || a == c)
                return "Рівнобедрений";
            return "Різносторонній";
        }
    }
}
