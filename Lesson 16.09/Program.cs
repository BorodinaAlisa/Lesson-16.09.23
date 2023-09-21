using System;
enum BankAccountType
{
    Current,
    Savings
}
namespace bank_account
{
    struct bankaccount
    {
        public int account_number;
        public string account_type;
        public double balance;
    }
}
enum University
{
    KGU,
    KAI,
    KHTI
}
struct worker
{
    public string name;
    public University university;
}

namespace Lesson_16._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1.Создать перечислимый тип данных отображающий виды банковского счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей значение и вывести это значение.");
            BankAccountType accountType = BankAccountType.Current;
            Console.WriteLine($"Тип банковского счета: {accountType}");
            Console.WriteLine("Упражнение 3.2.Создать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру значениями и напечатать результат.");
            Console.WriteLine("Введите номер счета:");
            int account_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите тип счета:");
            string account_type = Console.ReadLine();
            Console.WriteLine("Введите баланс счета:");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Номер счета: {account_number}");
            Console.WriteLine($"Тип счета: {account_type}");
            Console.WriteLine($"Баланс счета: {balance}");
            Console.WriteLine("Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными.");
            worker worker1;
            Console.Write("Введите имя работника:");
            worker1.name = Console.ReadLine();
            Console.Write("Введите вуз работника (КГУ, КАИ или КХТИ) английскими заглавными буквами:");
            worker1.university = (University)Enum.Parse(typeof(University), Console.ReadLine());
            worker worker2;
            Console.Write("Введите имя работника:");
            worker2.name = Console.ReadLine();
            Console.Write("Введите вуз работника (КГУ, КАИ или КХТИ) английскими заглавными буквами:");
            worker2.university = (University)Enum.Parse(typeof(University), Console.ReadLine());
            worker worker3;
            Console.Write("Введите имя работника:");
            worker3.name = Console.ReadLine();
            Console.Write("Введите вуз работника (КГУ, КАИ или КХТИ) английскими заглавными буквами:");
            worker3.university = (University)Enum.Parse(typeof(University), Console.ReadLine());
            Console.WriteLine("Имя: {0}, ВУЗ: {1}", worker1.name, worker1.university);
            Console.WriteLine("Имя: {0}, ВУЗ: {1}", worker2.name, worker2.university);
            Console.WriteLine("Имя: {0}, ВУЗ: {1}", worker3.name, worker3.university);
            Console.ReadKey();
            


        }
    }
}
