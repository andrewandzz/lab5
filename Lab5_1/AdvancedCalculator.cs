using System;

namespace Lab5_1;

class AdvancedCalculator : OrdinaryCalculator
{
    public AdvancedCalculator() : base()
    {
        operations = new string[] { "+", "-", "*", "/", "байт -> кілобайт" };
    }

    public override void PrintIntro()
    {
        Console.WriteLine("Інженерний режим калькулятора.");
    }

    public double ByteToKilobyte()
    {
        return Num1 / 1024;
    }
}