using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
public class Calculator17
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double D { get; set; }

    public Calculator17(double a, double b, double c, double d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }
    public bool CalculatorA()
    {
        int counter3 = 0;
        int counter5 = 0;
        List<double> nums = new List<double>() { A, B, C, D };
        foreach (double i in nums)
        {
            if (i % 3 == 0)
                counter3++;

            if (i % 5 == 0)
                counter5++;
        }
        return counter3 == 1 && counter5 == 1;
    }
}