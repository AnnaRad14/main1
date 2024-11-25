using System;

namespace pz1
{
    class Task1 : ITask
    {
        private const int StudentNumber = 4; 

        public void Execute()
        {
            Console.WriteLine("Введіть три цілих числа:");
            int[] numbers = new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Число {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число.");
                    i--;
                    continue;
                }
            }

            Console.WriteLine($"Числа, які належать інтервалу [1,{10 + StudentNumber}]:");
            foreach (int num in numbers)
            {
                if (num >= 1 && num <= 10 + StudentNumber)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
