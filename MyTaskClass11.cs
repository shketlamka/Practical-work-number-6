using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp41;
class Calculator11
{
    private double N { get; set; }
    private double S { get; set; }


    public Calculator11 (double n)
    {
        N = n;

        if (N > 4000 && N < 6000)
        {
            S = 0.05;
        }
        else if (N > 6000 && N <= 10000)
        {
            S = 0.10;
        }
    }
    
    public double CalculatorA()
    {
        
        return N * S;
    }
}
