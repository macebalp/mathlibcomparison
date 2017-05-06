using CosineComparison.Cotracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison.Implementation
{
    public class PlainCosineCalculator : ICosineDistanceCalculator
    {
        public float GetCosineDistance(float[] vector1, float[] vector2)
        {
            float sum=0, norm1=0, norm2 = 0, x1, x2;
            int workingLength = vector1.Length;
            for (int i = 0; i < workingLength; i++)
            {
                x1 = vector1[i];
                x2 = vector2[i];

                sum += x1 * x2;
                norm1 += x1 * x1;
                norm2 += x2 * x2;
            }
            return sum / (float)Math.Sqrt(norm1 * norm2);
        }

        
    }
}
