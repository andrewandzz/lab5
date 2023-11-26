using System;

namespace Lab5_1;

class Program
{
    static void Main()
    {
        PrintIntro();

        while (true)
        {
            PrintOptions();

            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                PrintOutro();
                break;
            }

            if (int.TryParse(input, out int mode))
            {
                switch (mode)
                {
                    case 1:
                        Console.WriteLine("Gone to mode 1 and gone out of it");
                        continue;
                    case 2:
                        Console.WriteLine("Gone to mode 2 and gone out of it");
                        continue;
                }
            }

            PrintErrorMessage("Некоректно вибраний режим. Повторіть введення.");
        }
    }

    static void PrintIntro()
    {
        Console.WriteLine("Дана програма є калькулятором, що має два режими роботи: \"стандартний\" та \"інженерний\".");
    }

    static void PrintOptions()
    {
        Console.WriteLine("Виберіть режим калькулятора:");
        Console.WriteLine("1. Стандартний");
        Console.WriteLine("2. Інженерний");
        Console.WriteLine("Або введіть \"exit\", щоб завершити роботу програми:");
    }

    static void PrintErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    static void PrintOutro()
    {
        Console.WriteLine("Дякуємо за користування програмою!");
        Console.WriteLine("Програму підготували студенти 121 спеціальності:\nЄлизавета Розсохач, Ярослава Сальтевська, Андрій Дашков, Вікторія Долга.");
    }
}
