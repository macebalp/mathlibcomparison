using CosineComparison.Cotracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison.Implementation
{
    public class BaseMultiCosineCalculator : IMultiCosineDistanceCalculator
    {
        ICosineDistanceCalculator singleCalc;
        public BaseMultiCosineCalculator(ICosineDistanceCalculator calc) 
        {
            this.singleCalc = calc;
        }

        public float[] GetCosineDistance(float[][] vectors1, float[][] vectors2)
        {
            int m1Length = vectors1.Length,
                m2Length = vectors2.Length;

            float[] result = new float[m1Length * m2Length];
            for (int i = 0; i < m1Length; i++)
                for (int j = 0; j < m2Length; j++)
                    result[(i * m2Length) + j] = singleCalc.GetCosineDistance(vectors1[i], vectors2[j]);

            return result;
        }

        public double[] GetCosineDistance(double[][] vectors1, double[][] vectors2)
        {
            int m1Length = vectors1.Length,
                m2Length = vectors2.Length;

            double[] result = new double[m1Length * m2Length];
            for (int i = 0; i < m1Length; i++)
                for (int j = 0; j < m2Length; j++)
                    result[(i * m2Length) + j] = singleCalc.GetCosineDistance(vectors1[i], vectors2[j]);

            return result;
        }
    }
}
