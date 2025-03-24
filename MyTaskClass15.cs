using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp41;
class Calculator15
{
    public int physics { get; set; }
    public int mathematic { get; set; }
    public int informatic { get; set; }

    public Calculator15(double math, double phys, double info)
    {

        mathematic = Convert.ToInt32(math);
        physics = Convert.ToInt32(phys);
        informatic = Convert.ToInt32(info);

    }
    public bool CalculatorA()
    {
        return (mathematic == 4 || mathematic == 5) && (physics == 4 || physics == 5) && (informatic == 4 || informatic == 5);
    }
}