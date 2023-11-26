using System;

namespace Lab5_2;

class AdvancedCalculator : OrdinaryCalculator, IAdvancedCalculator
{
    public override string[] Operations => new string[] { "+", "-", "*", "/", "байт -> кілобайт" };

    public AdvancedCalculator() : base()
    {
        Make = "Інженерний";
    }

    public double ByteToKilobyte()
    {
        return Num1 / 1024;
    }
}