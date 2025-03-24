using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
class Calculator9
{
    private double N { get; set; }
    private double M { get; set; }
    private double K { get; set; }
    private double L { get; set; }


    public Calculator9(double n, double m, double k, double l)
    {
        N = n;
        M = m;
        K = k;
        L = l;
    }
    public bool CalculatorA()
    {
        return K == 0 & L > M && K < 0 & (2 * L - 3 * N) < M;
    }
}


