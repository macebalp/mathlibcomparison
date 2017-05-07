using AForge.Math.Metrics;
using CosineComparison.Cotracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison.Implementation
{
    public class AForgeCosineCalculator : ICosineDistanceCalculator
    {
        CosineSimilarity sim;

        public AForgeCosineCalculator() 
        {
            sim = new CosineSimilarity();
        }

        public float GetCosineDistance(float[] vector1, float[] vector2)
        {
            return (float)sim.GetSimilarityScore(vector1.Select(x => (double)x).ToArray(), vector2.Select(x => (double)x).ToArray());
        }

        public double GetCosineDistance(double[] vector1, double[] vector2)
        {
            return sim.GetSimilarityScore(vector1, vector2);
        }
    }
}
