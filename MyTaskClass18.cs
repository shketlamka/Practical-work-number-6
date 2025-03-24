using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
public class Calculator18
{
    public double A { get; set; }
    public double B { get; set; }


    public Calculator18(double a)
    {
        A = a;
        if (A >= 10000 && A < 20000)
            B = 0.95;
        else if (A >= 20000 && A <= 50000)
            B = 0.9;
        else B = 1;
    }
    public double CalculateA()
    {
        return A * B;
    }
}
