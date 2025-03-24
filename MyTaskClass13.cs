using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41;
class Calculator13
{
    private double _time;
    private double _duration;
    private double _costPerMinute;
    private int _dayOfWeek;

    public Calculator13(double time, double duration, double costPerMinute, int dayOfWeek)
    {
        _time = time;
        _duration = duration;
        _costPerMinute = costPerMinute;
        _dayOfWeek = dayOfWeek;
    }

    public double CalculatorA()
    {
        double effectiveCost = _costPerMinute;

        if (_time >= 22 || _time < 0)
        {
            effectiveCost *= 0.8;
        }

        if(_dayOfWeek == 6 || _dayOfWeek == 7)
        {
            effectiveCost *= 0.9;
        }

        return effectiveCost * _duration;
    }
} 
