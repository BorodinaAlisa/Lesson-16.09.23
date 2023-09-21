using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
struct Student
{
    public string surname;
    public string name;
    public int ID;
    public DateTime datebirth;
    public char alcoholismcategory;
    public double alcoholvolume;

}

namespace zadanie_1_2_3_4_5_6_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.Вывести на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine("Тип данных\tМаксимальное значение\tМинимальное значение");

            Console.WriteLine("byte\t\t" + byte.MaxValue + "\t\t\t" + byte.MinValue);
            Console.WriteLine("sbyte\t\t" + sbyte.MaxValue + "\t\t\t" + sbyte.MinValue);
            Console.WriteLine("short\t\t" + short.MaxValue + "\t\t\t" + short.MinValue);
            Console.WriteLine("ushort\t\t" + ushort.MaxValue + "\t\t\t" + ushort.MinValue);
            Console.WriteLine("int\t\t" + int.MaxValue + "\t\t" + int.MinValue);
            Console.WriteLine("uint\t\t" + uint.MaxValue + "\t\t\t" + uint.MinValue);
            Console.WriteLine("long\t\t" + long.MaxValue + "\t" + long.MinValue);
            Console.WriteLine("ulong\t\t" + ulong.MaxValue + "\t\t\t" + ulong.MinValue);
            Console.WriteLine("float\t\t" + float.MaxValue + "\t\t" + float.MinValue);
            Console.WriteLine("double\t\t" + double.MaxValue + "\t\t" + double.MinValue);
            Console.WriteLine("decimal\t\t" + decimal.MaxValue + "\t" + decimal.MinValue);
            Console.WriteLine("char\t\t" + char.MaxValue + "\t\t\t" + char.MinValue);
            Console.WriteLine("bool\t\t" + bool.TrueString + "\t\t\t" + bool.FalseString) 
            Console.WriteLine("Задание 2.Написать программу, в которой принимаются данные пользователя в виде имени,города, возраста и PIN-кода.");
            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();
            Console.Write("Введите Ваш город:");
            string city = Console.ReadLine();
            Console.Write("Введите Ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Ваш PIN-код: ");
            string pincode = Console.ReadLine();
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"PIN-код: {pincode}");
            Console.WriteLine("Задание 3.Преобразовать входную строку: строчные буквы замените на заглавные, заглавные – на строчные.");
            Console.Write("Введите строку:");
            string inputstr = Console.ReadLine();
            string str1 = "";
            foreach (char symbol in inputstr)
            {
                if (Char.IsLower(symbol))
                {
                    str1 += Char.ToUpper(symbol);
                }
                else if (Char.IsUpper(symbol))
                {
                    str1 += Char.ToLower(symbol);
                }
                else
                {
                    str1 += symbol;
                }
            }
            Console.WriteLine($"Преобразованная строка: {str1}");          
            Console.WriteLine("Задание 5.Определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.");
            int normPrice = 10; 
            int salePrice = 10; 
            int holidayPrice = 500; 
            int bottlesNeeded = (int)Math.Ceiling((double)holidayPrice / (normPrice - (normPrice * salePrice / 100))); // Расчет количества бутылок, необходимых для покрытия расходов на отпуск
            Console.WriteLine($"Результат:{bottlesNeeded}");
            Console.WriteLine("Задание 6.Воспроизвести разговор Гарри Поттера и дневника Тома Реддла.");
            Console.WriteLine("Привет!Как тебя зовут?");
            string username = Console.ReadLine();
            Console.WriteLine($"Привет,{username}.");
            Console.WriteLine("Знаешь ли ты что-то о тайной комнате?");
            Console.WriteLine("Да");
            Console.WriteLine("Можешь ли рассказать?");
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать.");
            Random random = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = colors[random.Next(colors.Length)];
            Console.ResetColor();
            Console.WriteLine("Задание 8.Создать структуру студента.");
            Student[] students = new Student[5];
            students[0] = new Student()
            {
                surname = "Рыбаков",
                name = "Максим",
                ID = 1,
                datebirth = new DateTime(2001, 03, 12),
                alcoholismcategory = 'a',
                alcoholvolume = 12.0
            };

            students[1] = new Student()
            {
                surname = "Павлов",
                name = "Илья",
                ID = 2,
                datebirth = new DateTime(1999, 23, 03),
                alcoholismcategory = 'b',
                alcoholvolume = 5.2
            }; 

            students[2] = new Student()
            {
                surname = "Cмирнов",
                name = "Даниил",
                ID = 3,
                datebirth = new DateTime(1997, 15, 09),
                alcoholismcategory = 'с',
                alcoholvolume = 4.8
            };

            students[3] = new Student()
            {
                surname = "Иванова",
                name = "Марина",
                ID = 4,
                datebirth = new DateTime(2002, 17, 01),
                alcoholismcategory = 'd',
                alcoholvolume = 0
            };

            students[4] = new Student()
            {
                surname = "Спицин",
                name = "Влвдимир",
                ID = 5,
                datebirth = new DateTime(1993, 26, 02),
                alcoholismcategory = 'и',
                alcoholvolume = 6.2
            };

            double totalalcoholvolume = 0;

            foreach (var student in students)
            {
                totalalcoholvolume += student.alcoholvolume;
            }

            Console.WriteLine("Общий объем алкоголя: " + totalalcoholvolume + " литров");

            foreach (var student in students)
            {
                double percentage = (student.alcoholvolume / totalalcoholvolume) * 100;
                Console.WriteLine(student.surname + " " + student.name + " выпил " + percentage.ToString("0.00") + "%");
            }
            Console.ReadKey();




        }
    }
}
