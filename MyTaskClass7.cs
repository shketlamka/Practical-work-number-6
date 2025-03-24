using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
 class Calculator7
{ 
    private double N {  get; set; }

    public Calculator7(double n)
    {
        N = n;
    }
    public bool CalculatorA()
    {
        return N % 2 == 0 & N % 7 == 0 && N % 11 != 0 & N % 13 != 0;
    }

}
