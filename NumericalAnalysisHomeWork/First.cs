using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumericalAnalysisHomeWork
{
    class First
    {
        public float SUMFromSmallToBig(float N)
        {
            float sum = 0.0f;
            for (float i = N; i >= 2; i--)
            {
                sum += (float)(1.0f / ((float)i * i - (float)1.0f));
            }
            return sum;
        }

        public float SUMFromBigToSmall(float N)
        {
            float sum = 0.0f;
            for (float i = 2.0f; i <= N; i++)
            {
                sum += (float)(1.0f / ((float)i * i - (float)1.0f));
            }
            return sum;
        }

        public float RealResult(float N)
        {
            float result = 0.0f;
            result = 0.5f * (1.5f - (float)(1.0f/N) - (float)(1.0f/(N+1.0f)));
            return result;
        }
    }
}
