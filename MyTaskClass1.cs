using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
class NumberChecker
{
    private double A;
    private double B;
    private double C;

    public NumberChecker(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }  
    
    public bool IsOnlyOneEven()
    {
        return ((A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0));
    }

    public bool AreAllMultiplesOfThree() 
    {
        return (A % 3 == 0) && (B % 3 == 0) && (C % 3 == 0);
    }

 }
