using System;

namespace Lab5_2;

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
                        RunStandardMode();
                        continue;
                    case 2:
                        RunAdvancedMode();
                        continue;
                }
            }

            PrintErrorMessage("Некоректно вибраний режим. Повторіть введення.\n");
        }
    }

    static void PrintIntro()
    {
        Console.WriteLine("Дана програма є калькулятором, що має два режими роботи: \"стандартний\" та \"інженерний\".\n");
    }

    static void PrintOptions()
    {
        Console.WriteLine("Виберіть режим калькулятора (введіть 1 або 2):");
        Console.WriteLine("1. Стандартний");
        Console.WriteLine("2. Інженерний");
        Console.WriteLine("Або введіть \"exit\", щоб завершити роботу програми:");
    }

    static void RunStandardMode()
    {
        AbstractCalculator calculator = new OrdinaryCalculator();
        calculator.PrintIntro();

        while (true)
        {
            calculator.PrintOptions();

            var input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        RunAddition(calculator);
                        continue;
                    case 2:
                        RunSubtraction(calculator);
                        continue;
                    case 3:
                        RunMultiplication(calculator);
                        continue;
                    case 4:
                        RunDivision(calculator);
                        continue;
                }
            }

            PrintErrorMessage("Некоректно обрана опція. Повторіть введення.\n");
        }
    }

    static void RunAdvancedMode()
    {
        AdvancedCalculator calculator = new AdvancedCalculator();
        calculator.PrintIntro();

        while (true)
        {
            calculator.PrintOptions();

            var input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        RunAddition(calculator);
                        continue;
                    case 2:
                        RunSubtraction(calculator);
                        continue;
                    case 3:
                        RunMultiplication(calculator);
                        continue;
                    case 4:
                        RunDivision(calculator);
                        continue;
                    case 5:
                        RunByteToKilobyte(calculator);
                        continue;
                }
            }

            PrintErrorMessage("Некоректно обрана опція. Повторіть введення.\n");
        }
    }

    static void RunAddition(AbstractCalculator calculator)
    {
        Console.WriteLine("Операція додавання.");
        calculator.Num1 = ReadNumber("Введіть перше число:");
        calculator.Num2 = ReadNumber("Введіть друге число:");

        double result = calculator.Add();

        Console.WriteLine($"Відповідь: {result}\n");
    }

    static void RunSubtraction(AbstractCalculator calculator)
    {
        Console.WriteLine("Операція віднімання.");
        calculator.Num1 = ReadNumber("Введіть перше число:");
        calculator.Num2 = ReadNumber("Введіть друге число:");

        double result = calculator.Subtract();

        Console.WriteLine($"Відповідь: {result}\n");
    }

    static void RunMultiplication(AbstractCalculator calculator)
    {
        Console.WriteLine("Операція множення.");
        calculator.Num1 = ReadNumber("Введіть перше число:");
        calculator.Num2 = ReadNumber("Введіть друге число:");

        double result = calculator.Multiply();

        Console.WriteLine($"Відповідь: {result}\n");
    }

    static void RunDivision(AbstractCalculator calculator)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Операція ділення.");
                calculator.Num1 = ReadNumber("Введіть перше число:");
                calculator.Num2 = ReadNumber("Введіть друге число:");

                double result = calculator.Divide();

                Console.WriteLine($"Відповідь: {result}\n");

                break;
            }
            catch (DivideByZeroException)
            {
                PrintErrorMessage("Некоректне введення: спроба ділення на нуль.\n");
            }
        }
    }

    static void RunByteToKilobyte(AbstractCalculator calculator)
    {
        Console.WriteLine("Операція перетворення байтів у кілобайти.");
        calculator.Num1 = ReadNumberOfBytes("Введіть ціле число байтів в діапазоні від 1 до 10^9:");

        double result = ((IAdvancedCalculator)calculator).ByteToKilobyte();

        Console.WriteLine($"Відповідь: {result}\n");
    }

    static double ReadNumber(string message)
    {
        while (true)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                return number;
            }
            else
            {
                PrintErrorMessage("Некоректне введення.\n");
            }
        }
    }

    private static long ReadNumberOfBytes(string message)
    {
        while (true)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();

            if (long.TryParse(input, out long number) && number >= 1 && number <= 1000000000)
            {
                return number;
            }
            else
            {
                PrintErrorMessage("Некоректне введення.\n");
            }
        }
    }

    static void PrintErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    static void PrintOutro()
    {
        Console.WriteLine("\nДякуємо за користування програмою!");
        Console.WriteLine("Програму підготували студенти 121 спеціальності:\nЄлизавета Розсохач, Ярослава Сальтевська, Андрій Дашков, Вікторія Долга.");
    }
}
