using CosineComparison.Cotracts;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison.Implementation
{
    public class BaseParallelCosineCalculator : IMultiCosineDistanceCalculator
    {
        ICosineDistanceCalculator singleCalc;
        public BaseParallelCosineCalculator(ICosineDistanceCalculator calc) 
        {
            this.singleCalc = calc;
        }
        
        public float[] GetCosineDistance(float[][] vectors1, float[][] vectors2)
        {
            int m1Length = vectors1.Length,
                m2Length = vectors2.Length;
                
            float[] result = new float[m1Length * m2Length];
            Parallel.For(0, m1Length,
                (i) =>
                {
                    float[] vector1 = vectors1[i];
                    for (int j = 0; j < m2Length; j++)
                        result[(i * m2Length) + j] = singleCalc.GetCosineDistance(vector1, vectors2[j]);
                }
            );
            return result;
        }

        public double[] GetCosineDistance(double[][] vectors1, double[][] vectors2)
        {
            int m1Length = vectors1.Length,
                m2Length = vectors2.Length;

            double[] result = new double[m1Length * m2Length];
            Parallel.For(0, m1Length,
                (i) =>
                {
                    double[] vector1 = vectors1[i];
                    for (int j = 0; j < m2Length; j++)
                        result[(i * m2Length) + j] = singleCalc.GetCosineDistance(vector1, vectors2[j]);
                }
            );
            return result;
        }
        
    }
}
