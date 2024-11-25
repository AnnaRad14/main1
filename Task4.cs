using System;
using System.Linq;

namespace pz1
{
    class Task4 : ITask
    {
        private const int StudentNumber = 4; 
        public void Execute()
        {
            int arrayLength = 10 + StudentNumber;
            int[] arrayX = new int[arrayLength];
            Random random = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                arrayX[i] = random.Next(-100, 101);
            }

            Console.Write("Введіть число M: ");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Некоректне введення числа M.");
                return;
            }

            var arrayY = arrayX.Where(x => Math.Abs(x) > m).ToArray();

            Console.WriteLine($"Число M: {m}");
            Console.WriteLine("Масив X:");
            Console.WriteLine(string.Join(", ", arrayX));
            Console.WriteLine("Масив Y - елементи, які більші за |M|:");
            Console.WriteLine(string.Join(", ", arrayY));
        }
    }
}
