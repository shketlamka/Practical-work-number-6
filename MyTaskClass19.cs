using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
public class Calculator19
{
    private double A { get; set; }
    private double B { get; set; }

    public Calculator19(double a)
    {
        A = a;
        if (A >= 5 && A < 10)
            B = 0.98;
        else if (A >= 10 && A <= 20)
            B = 0.9;
        else B = 1;
    }
    public double CalculateA()
    {
        return B;
    }
}