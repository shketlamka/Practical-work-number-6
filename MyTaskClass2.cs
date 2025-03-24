using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
class MyTaskClass2
{
    private double N;

    public MyTaskClass2(double n)
    {
        N = n;
    }

    public bool A2()
    {
        return (N % 4 == 0) || (N % 7 == 0);
    }

    public bool B2()
    {
        return (N % 5 == 0) && (N % 10 != 0);
    }

}
