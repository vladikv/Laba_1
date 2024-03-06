using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            int temp = 0;
            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
            }

            Console.WriteLine("Результат:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
