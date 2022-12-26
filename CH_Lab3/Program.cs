using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №3\n");
            double leftBorder = 0.1d;
            int rightBorder = 1;
            for (var x = leftBorder; x <= rightBorder; x += (rightBorder - leftBorder) / 10)
            {
                double step = 1, sumSteps = 1, sumEps = 1;
                for (var index = 1; index <= 35; ++index)
                {
                    step *= Math.Pow(x, 2) / ((2 * index - 1) * 2 * index);
                    sumSteps += Math.Pow(-1, index) * (2 * index * index + 1) * step;
                }

                double eps = 0.0001;
                double stepEps = 1;
                int indexEps = 1;
                while (Math.Abs(stepEps) >= eps)
                {
                    stepEps *= Math.Pow(x, 2) / ((2 * indexEps - 1) * 2 * indexEps);
                    sumEps += Math.Pow(-1, indexEps) * (indexEps * indexEps * 2 + 1) * stepEps;
                    indexEps++;
                }
                double y = ((1 - ((x * x) / 2)) * Math.Cos(x) - ((x * x) / 2 * Math.Sin(x)));
                Console.WriteLine($"X = {x:f2} \tSN = {sumSteps:f6} \tSE = {sumEps:f6} \tY = {y:f6}");
            }
            Console.ReadLine();
        }
    }
}
