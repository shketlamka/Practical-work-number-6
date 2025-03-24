using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
public class Calculator16
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double D { get; set; }

    public Calculator16(double a, double b, double c, double d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }
    public bool CalculatorA()
    {
        int counter = 0;
        List<double> nums = new List<double>() {A, B, C, D};
        foreach (double i in nums)
        {
            if(i % 2 == 0) 
                counter++;
        }
        return counter == 2;
    }

}
