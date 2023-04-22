using System;
using System.Collections.Generic;

namespace AreaCalculation
{
    public class Circle : IShape
    {
        public double r;

        public Circle(double r)
        {
            this.r = r;        
        }

        public List<String> Calculation()
        {
            List<String> result = new List<String>();
            result.Clear();

            var S = Math.PI * Math.Pow(r, 2);
            result.Add(Math.Round(S, 2).ToString());
            return result;
        }
    }
}
