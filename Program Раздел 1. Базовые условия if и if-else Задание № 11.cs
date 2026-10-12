using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                bool isThreeDigit = (n >= 100 && n <= 999) || (n <= -100 && n >= -999);
                Console.WriteLine(isThreeDigit ? "Да" : "Нет");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}