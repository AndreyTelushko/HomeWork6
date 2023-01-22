using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите числа через запятую, без пробелов. \nПример: 1,2,3,4 \n");
            string input = Console.ReadLine();
            Console.WriteLine($"Чисел больше нуля: {Counter(input)}");
        }

        public static int Counter(string input)
        {
            var array = input.Split(',');

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (int.Parse(array[i]) > 0) result++;
            }

            return result;
        }
    }
}
