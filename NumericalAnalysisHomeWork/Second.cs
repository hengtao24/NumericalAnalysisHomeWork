using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumericalAnalysisHomeWork
{
    class Second
    {
        public double Newton(double x0, double er)
        {
            double x1; 
            while (true)
            {
                x1 = x0 - (double) fx(x0) / df(x0);
                if (Math.Abs(x1-x0) <= er)
                {
                    break;
                }
                x0 = x1;
            }
            return x0;
        }

        public double fx(double x)
        {
            return (double) (x * x * x / 3 - x);
        }

        public double df(double x)
        {
            return (double)(x * x - 1);
        }

        public double FindMaxSigma(double step,double er)
        {
            int k = 0;  
            int times = 0;
            double sigma;
            double x0;
            double x1;
            while (true)
            {
                sigma = k * step;
                x0 = sigma;
                times = 0;
                while (true && times < 1000)  
                {
                    x1 = x0 - (double)fx(x0) / df(x0);
                    if (Math.Abs(x1 - x0) <= er)
                    {
                        break;
                    }
                    x0 = x1;
                    times++;
                }

                if (times == 1000 || Math.Abs(x0) >= er) 
                {
                    break;
                }

                k++;
            }
            return k * step;
        }
    }
}
