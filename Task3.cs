using System;

namespace pz1
{
    class Task3 : ITask
    {
        private const int StudentNumber = 4; 

        public void Execute()
        {
            int arrayLength = 10 + StudentNumber;
            int[] array = new int[arrayLength];
            Random random = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(-100, 101);
            }

            int min = array[0];
            int max = array[0];
            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            Console.WriteLine("Масив X:");
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine($"Мінімальне значення: {min}");
            Console.WriteLine($"Максимальне значення: {max}");
        }
    }
}
