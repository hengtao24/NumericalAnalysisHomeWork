using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumericalAnalysisHomeWork
{
    public class Fifth
    {
        public double TanSumofSquare(double x, double y)
        {
            double result = 0.0d;
            result = Math.Tan(x*x + y*y);
            return result;
        }

        public double GetIntergal(double a,double b,double c,double d,double h,double k)
        {
            double result = 0.0d;
            result = h * k / 4.0 * (TanSumofSquare(a, c) + TanSumofSquare(a, d) + TanSumofSquare(b, c) + TanSumofSquare(b, d));
            return result;
        }

        public double CalculateResult(double a, double b, double c, double d, double ToleranceError)
        {
            double h, k;    // 步长
            h = b - a;
            k = d - c;
            int m, n;
            m = 1;
            n = 1;
            double Tf = 0;
            double Tfnew = 0;
            Tfnew = GetIntergal(a, b, c, d, h, k);
            Tf = Tfnew + 1;
            // 计算过程中不同阶数精度数值
            double[] T0 = new double[100];
            double[] T1 = new double[100];
            double[] T2 = new double[100];
            double[] T3 = new double[100];
            int index = 0;
            while ((Math.Abs(Tf-Tfnew)>ToleranceError) && m < 10000)
            {
                n = n * 2;
                m = m * 2;
                h = (b - a) / m;
                k = (d - c) / n;
                Tf = Tfnew;
                double temp=0,temp1,temp2,temp3,temp4,temp5,temp6;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n;j++ )
                    {
                        temp1 = a + 1.0 * (i + 0.5) * h;   // X(i+1/2) 
                        temp2 = c + 1.0 * (j + 0.5) * k;   // Y(i+1/2) 
                        temp3 = a + 1.0 * i * h;           // Xi
                        temp4 = c + 1.0 * j * k;           // Yi
                        temp5 = a + 1.0 * (i + 1) * h;     // X(i+1)
                        temp6 = c + 1.0 * (j + 1) * k;     // Y(i+1)
                        temp += TanSumofSquare(temp1, temp4) + TanSumofSquare(temp3, temp2) + TanSumofSquare(temp5, temp2)
                            + TanSumofSquare(temp1, temp6) + 2*TanSumofSquare(temp1, temp2);   
                    }
                }
                temp = 1.0* temp * h * k / 8;
                Tfnew = Tf / 4 + temp;
                T0[index] = Tfnew;
                index++;
            }

            // 计算更高阶精度数值
            for (int i = 0; i < (index - 1); i++)
            {
                T1[i] = 4.0 / 3 * (T0[i + 1]) - 1.0 / 3 * (T0[i]);
            }
            for (int i = 0; i < (index - 2); i++)
            {
                T2[i] = 16.0 / 15 * (T1[i + 1]) - 1.0 / 15 * (T1[i]);
            }
            for (int i = 0; i < (index - 3); i++)
            {
                T3[i] = 64.0 / 63 * (T2[i + 1]) - 1.0 / 63 * (T2[i]);
            }

            return c;
        }

    }
}
