using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
 class Calculator8
{
    private double N {  get; set; }

    public Calculator8(double n)
    {
        N = n;
    }
    public bool CalculatorA()
    {
        return N % 3 != 0 & N % 7 == 0 & N % 10 == 0;
    }
}
