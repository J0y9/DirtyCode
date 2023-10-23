using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtyCode
{
    public interface IOperation
    {
        double Calculate(double firstNumber,double secondNumber);
    }
}
