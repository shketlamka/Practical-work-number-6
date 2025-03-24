using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
class Calculator5
{
    private double K { get; set; }
    private double L { get; set; }
    private double N { get; set; }
    private double M { get; set; }



    public Calculator5(double n, double m, double k, double l)
    {
        N = n;
        M = m;
        K = k;
        L = l;
    }

    public bool CalculatorA()
    {
        return N > 1 || (M <= L + K && L + K == 0) && (N > 2 == (Math.Pow(M, 2) > Math.Pow(L, 2)));
    }


}
