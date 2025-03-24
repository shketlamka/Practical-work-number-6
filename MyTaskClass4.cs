using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
 class Calculator4
{
   private double N { get; set; }

    public Calculator4(double n)
    {
        N = n;
    }

    public bool CalculatorA()
    {
        return (N % 3 == 0) && (N % 9 != 0 ) && (N % 4 == 0) && (N % 5 == 0) && (N % 24 == 0);
    }


}

