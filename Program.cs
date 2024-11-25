using pr1;
using System;

namespace pz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            ITask[] tasks = {
                new Task1(),
                new Task2(),
                new Task3(),
                new Task4()
            };

            TaskController controller = new TaskController(tasks);
            controller.RunAll();

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}