using System;
using System.Collections.Generic;

namespace AreaCalculation
{
    public interface ICalculation
    {
        double Circle(double r);
        List<String> Triangle(double x, double y, double z);
    }
}
