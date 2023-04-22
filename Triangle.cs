using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Triangle : IShape
    {
        public double x;
        public double y;
        public double z;

        public Triangle(double x, double y, double z) 
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public List<string> AreaCalculation()
        {
            List<string> result = new List<String>();
            result.Clear();
            double S;
            double p = (x + y + z) / 2;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            if (S <= 0)
            {
                result.Add("0");
                result.Add("Не является треугольником");
            }
            else
            {
                result.Add(Math.Round(S, 2).ToString());

                if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2) || Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(y, 2) || Math.Pow(y, 2) + Math.Pow(z, 2) == Math.Pow(x, 2))
                {
                    result.Add("Площадь прямоугольного треугольника");
                }
                else
                {
                    result.Add("Площадь треугольника");
                }
            }

            return result;
        }
    }
}
