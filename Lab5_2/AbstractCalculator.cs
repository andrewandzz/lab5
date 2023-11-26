using System;

namespace Lab5_2;

abstract class AbstractCalculator
{
    private double num1;
    private double num2;
    private string make;

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

    public string Make { get => make; protected set => make = value; }

    public abstract string[] Operations { get; }

    public void PrintIntro()
    {
        Console.WriteLine($"{make} режим калькулятора.");
    }

    public void PrintOptions()
    {
        Console.WriteLine("Виберіть операцію:");

        for (int i = 0; i < Operations.Length; i++)
        {
            int number = i + 1;
            string symbol = Operations[i];
            Console.WriteLine($"{number}. {symbol}");
        }

        Console.WriteLine("Або введіть \"exit\", щоб вийти з цього режиму:");
    }

    public abstract double Add();

    public abstract double Subtract();

    public abstract double Multiply();

    public abstract double Divide();
}