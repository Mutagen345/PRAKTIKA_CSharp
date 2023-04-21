using System;

namespace FigureCalculations
{
    class Program
    {
        delegate double CalcFigure(double R);

        static void Main(string[] args)
        {
            CalcFigure CF = null;

            CF += Get_Length;
            CF += Get_Area;
            CF += Get_Volume;

            double radius = 5.0;
            foreach (CalcFigure method in CF.GetInvocationList())
            {
                double result = method(radius);
                Console.WriteLine($"Результат: {result}");
            }
        }

        static double Get_Length(double R)
        {
            double D = 2 * Math.PI * R;
            return D;
        }

        static double Get_Area(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            return S;
        }

        static double Get_Volume(double R)
        {
            double V = (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
            return V;
        }
    }
}
