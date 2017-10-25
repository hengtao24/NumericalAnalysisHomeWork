using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumericalAnalysisHomeWork
{
    class Third
    {
        public double[] ColumnPrincipalGauss(double[,] A, double[] b)
        {
            double[] x = new double[b.Length];
            double[,] newA = new double[9, 10];
            for (int i = 0; i < 10;i++ )
            {

                for (int j = 0;j<9;j++)
                {
                    if (i == 9)
                    {
                        newA[j, i] = b[j];
                    }
                    else
                    {
                        newA[j, i] = A[j, i]; 
                    }
                }               
            }

            for (int i = 0; i < b.Length - 1;i++ )
            {
              //  double max = newA[i];
                int maxLine;
                double[] data = new double[b.Length-i];
                double[] temp = new double[b.Length];

                // get max index
                for (int j = i;j<b.Length-1;j++)
                {
                    data[j-i] = Math.Abs(newA[j,i]);
                }
                maxLine = getMaxIndex(data) + i;

                // line change
                for (int j = 0; j < b.Length - 1; j++)
                {
                    temp[j] = newA[maxLine, j];
                }

                for (int j = 0; j < b.Length - 1; j++)
                {
                    newA[maxLine, j] = newA[i,j];
                }

                for (int j = 0; j < b.Length - 1; j++)
                {
                    newA[i, j] = temp[j];
                }

                // 消元
                for (int k = i+1; k < b.Length;k++ )
                {
                    if (newA[k, i] != 0)
                    {
                        double temp1 = newA[k, i] / newA[i, i];

                        for (int j =i; j < b.Length + 1; j++)
                        {
//                             newA[k, j] = newA[k, j] - (double)(1.0d * newA[k, i] * newA[i, j] / newA[i, i]);         
                            newA[k, j] = newA[k, j] - (double)(1.0d * temp1 * newA[i, j]);                            

                        }
                    }                
                }
            }

            // 回代求解
            x[b.Length-1] = newA[b.Length-1,b.Length]/ newA[b.Length-1,b.Length-1];
            for (int i = b.Length - 2; i >= 0;i-- )
            {   
                double sum=0;
                for (int j = i+1;j<b.Length;j++)
                {
                    sum += newA[i,j] * x[j];
                }
                x[i] = (newA[i,b.Length] - sum) / newA[i,i];
            }
            return x;
        }

        public int getMaxIndex(double[] data)
        {
            double max = 0.0d;
            int index = 0;
            for (int i = 0; i < data.Length - 1;i++ )
            {
                if (data[i] >= max)
                {
                    max = data[i];
                    index = i;
                }
            }
            return index;
        }

    }
}
