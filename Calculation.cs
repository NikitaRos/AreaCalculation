using System;
using System.Collections.Generic;

namespace AreaCalculation
{
    public class Calculation : ICalculation
    {
        //Метод находит площадь круга 
        public double Circle(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            return Math.Round(S, 2);
        }

        // Метод находит площадь треугольника и делает проверку прямоугольный треугольник или нет
        public List<String> Triangle(double x, double y, double z)
        {
            List<String> list = new List<String>();
            list.Clear();
            double S;
            double p = (x + y + z) / 2;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            if (S <= 0)
            {
                list.Add("0");
                list.Add("Не является треугольником");
            }
            else
            {
                list.Add(Math.Round(S, 2).ToString());

                if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2) || Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(y, 2) || Math.Pow(y, 2) + Math.Pow(z, 2) == Math.Pow(x, 2))
                {
                    list.Add("Площадь прямоугольного треугольника");
                }
                else
                {
                    list.Add("Площадь треугольника");
                }
            }
            
            return list;
        }
    }
}
