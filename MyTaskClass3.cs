using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
 class Calculator3
 {
    private double N { get; set; }
    private double M { get; set; }
    private double L { get; set; }
    private double K { get; set; }



    public Calculator3(double n, double m, double k, double l)
    {
        N = n;
        M = m;
        K = k;
        L = l;
    }

    public bool CalculatorA()
    {
        return (N + M) > K && N > K == M < L; 
    }


 }
