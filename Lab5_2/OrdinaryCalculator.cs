using System;

namespace Lab5_2;

class OrdinaryCalculator : AbstractCalculator
{
    public override string[] Operations => new string[] { "+", "-", "*", "/" };
    
    public OrdinaryCalculator()
    {
        Make = "Стандартний";
    }

    public override double Add()
    {
        return Num1 + Num2;
    }

    public override double Subtract()
    {
        return Num1 - Num2;
    }

    public override double Multiply()
    {
        return Num1 * Num2;
    }

    public override double Divide()
    {
        if (Num2 == 0)
        {
            // throwing an exception manually, because dividing a floating-point value by zero doesn't throw an exception;
            // it results in positive infinity, negative infinity, or not a number (NaN), according to the rules of IEEE 754 arithmetic
            throw new DivideByZeroException();
        }

        return Num1 / Num2;
    }

    protected static void PrintErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}