using System;

namespace Lab5_1;

class OrdinaryCalculator
{
    protected string[] operations;
    protected double num1;
    protected double num2;

    public double Num1
    {
        get => num1;
        set => num1 = value;
    }

    public double Num2
    {
        get => num2;
        set => num2 = value;
    }

    public OrdinaryCalculator()
    {
        operations = new string[] { "+", "-", "*", "/" };
    }

    public virtual void PrintIntro()
    {
        Console.WriteLine("Стандартний режим калькулятора.");
    }

    public void PrintOptions()
    {
        Console.WriteLine("Виберіть операцію:");

        for (int i = 0; i < operations.Length; i++)
        {
            int number = i + 1;
            string symbol = operations[i];
            Console.WriteLine($"{number}. {symbol}");
        }

        Console.WriteLine("Або введіть \"exit\", щоб вийти з цього режиму:");
    }

    public double Add()
    {
        return Num1 + Num2;
    }

    public double Subtract()
    {
        return Num1 - Num2;
    }

    public double Multiply()
    {
        return Num1 * Num2;
    }

    public double Divide()
    {
        if (Num2 == 0)
        {
            // throwing an exception manually, because dividing a floating-point value by zero doesn't throw an exception;
            // it results in positive infinity, negative infinity, or not a number (NaN), according to the rules of IEEE 754 arithmetic
            throw new DivideByZeroException();
        }

        return Num1 / Num2;
    }
}