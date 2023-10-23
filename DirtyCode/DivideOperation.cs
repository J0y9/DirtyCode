using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtyCode
{
    public class DivideOperation : IOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }

            throw new ArgumentException("divide on zero",nameof(secondNumber));
        }
    }
}
