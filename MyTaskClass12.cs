using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
class Calculator12
{
    private double N { get; set; }
    private double M { get; set; }
    private double L { get; set; }
    private double K { get; set; }



    public Calculator12(double n, double m, double k, double l)
    {
        N = n;
        M = m;
        K = k;
        L = l;
    }

    public bool CalculatorA()
    {
        if (K + L + M + N <= 0)
        {
            return false;
        }
        if (K > 0)
        {
            if (2 * M <= K)
            {
                return false;
            }
        }
        if (K < 0)
        {
            if (N <= 3 * L)
            {
                return false;
            }
        }
        return true;
    }


}
