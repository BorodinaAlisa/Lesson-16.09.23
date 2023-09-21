using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labоratory_2_chapters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1.Написать программу,которая спрашивает имя пользователя и привествует его.");
            Console.WriteLine("Введите имя пользователя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}!");
            Console.WriteLine("Упражнение 2.2.Написать программу,на вход которой даётся два числа, а на выходе результат деления одного числа на другое.Также предусмотреть деление на 0.");
            Console.WriteLine("Введите два числа:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());           
            if (number2 != 0)
            { 
                double del = number1 / number2;
                Console.WriteLine($"Рузультат:{del}");
            }
            else
            {
                Console.WriteLine("Ошибка.Деление на ноль!");
            }
            Console.WriteLine("Домашние задание 2.1.Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.");
            Console.WriteLine("Введите букву английского алфавита:");
            char letter = Console.ReadKey().KeyChar;
            if (letter >= 'a' && letter <= 'z')
            {
                char nextletter = (char)(letter + 1);
                Console.WriteLine($"\nCледующая буква: {nextletter}");
            }
            else
            {
                Console.WriteLine("\nОшибка!");
            }
            Console.WriteLine("Домашние задание 2.2.Написать программу, которая решает квадратное уравнение.");
            Console.WriteLine("Введите коэффициенты для квадратного уравнения.");
            Console.WriteLine("a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c");
            double c = Convert.ToDouble(Console.ReadLine());
            double diskriminant = b * b - (4 * a * c);
            if (diskriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(diskriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(diskriminant)) / 2 * a;
                Console.WriteLine($"Корни квадратного уравнения: х1 = {x1} , x2 = {x2}");
            }
            else if (diskriminant == 0)
            {
                double x1 = (-b + Math.Sqrt(diskriminant)) / 2 * a;
                Console.WriteLine($"Корень квадратного уравнения: x = {x1}");
            }
            else
            {
                Console.WriteLine("Уравнениe не имеет корней");
            }
            Console.ReadKey();





        }
    }
}
