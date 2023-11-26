using System;

namespace Lab5_1;

class OrdinaryCalculator
{
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