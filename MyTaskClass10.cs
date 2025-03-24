using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
class Calculator10
{
    private double N { get; set; }

    public Calculator10(double n)
    {
        N = n;
    }
    public bool CalculatorA()
    {
        return (N % 2 == 0) && N % 3 != 0 && N % 7 == 0 && (N % 5 != 0) && (N % 4 != 0) && (N % 8 == 0) && (N % 11 == 0);
    }
}
