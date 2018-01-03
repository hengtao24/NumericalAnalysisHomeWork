using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumericalAnalysisHomeWork
{
    public class Fourth
    {
        public double[] CalculateSx(double[] x,double[] y,double y_0,double y_n)
        {
            double[,] A = CalculateA(x, y);
            double[] d = CalculateD(x, y, y_0, y_n);
            double[] M = CalculateM(A, d);
            return M;
        }

        public double[,] CalculateA(double[] x,double[] y)
        {
            int len = x.Length;
            double[,] arrray1 = new double[len,len+1];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    arrray1[i,j] = 0;
                }
            }
            arrray1[0, 1] = 1;
            arrray1[len - 1, len - 2] = 1;
            for (int i = 0; i < len;i++ )
            {
                arrray1[i, i] = 2;
            }
            for (int i = 1; i < len - 1;i++ )
            {
                double u = 1.0 * (x[i] - x[i - 1]) / (x[i + 1] - x[i - 1]);
                double w = 1 - u;
                arrray1[i, i - 1] = u;
                arrray1[i, i + 1] = w;
            }
            return arrray1;
        }

        public double[] CalculateD(double[] x,double[] y,double y_0,double y_n)
        {
            int len = x.Length;
            double[] d  = new double[len];
            d[0] = 6 * ((y[1] - y[0]) / (x[1] - x[0]) - y_0) / (x[1] - x[0]);
            d[len - 1] = 6 * (y_n - (y[len-1] - y[len-2]) / ((x[len - 1] - x[len - 2]))) / (x[len - 1] - x[len - 2]);
            for (int i = 1; i < len - 1;i++ )
            {
                d[i] = 6 * ((y[i] - y[i - 1]) / (x[i] - x[i - 1]) - (y[i+1] - y[i]) / (x[i+1] - x[i])) / (x[i+1] - x[i-1]);
            }
            return d;
        }

        public double[] CalculateM(double[,] A,double[] d)
        {
            // 追赶法
            int len = d.Length;
            double[] b = new double[len];
            double[] y = new double[len];
            double[] l = new double[len];
            double[] M = new double[len];
            b[0] = A[0,0];
            y[0] = d[0];
            for (int i = 1; i < len; i++)    //消元过程
            {
                l[i] = A[i,i - 1] / b[i - 1];
                b[i] = A[i,i] - l[i] * A[i - 1,i];
                y[i] = d[i] - l[i] * y[i - 1];
            }
            M[len - 1] = y[len - 1] / b[len - 1];
            for (int i = len - 2; i >= 0; i--)
            {
                M[i] = (y[i] - A[i,i + 1] * M[i + 1]) / b[i];
            }
            return M;
        }

    }
}
