namespace DirtyCode;


public class SubtractOperation : IOperation
{
    public double Calculate(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }
}