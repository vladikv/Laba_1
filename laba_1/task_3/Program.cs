using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { -1, 2, 3, 4, 5, -6, 7, 8, 9, 10 }; 

            int positiveCount = numbers.Count(n => n > 0);
            int oddSum = numbers.Where(n => n % 2 != 0).Sum();

            Console.WriteLine("Кількість додатних елементів: " + positiveCount);
            Console.WriteLine("Сума непарних елементів: " + oddSum);
        }
    }
}
