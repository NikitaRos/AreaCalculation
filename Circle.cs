using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AreaCalculation
{
    public class Circle : IShape
    {
        public double r;

        public Circle(double r)
        {
            this.r = r;        
        }

        public List<string> AreaCalculation()
        {
            List<string> result = new List<string>();
            result.Clear();

            var S = Math.PI * Math.Pow(r, 2);
            result.Add(Math.Round(S, 2).ToString());
            return result;
        }
    }
}
