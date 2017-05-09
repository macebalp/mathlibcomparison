using CosineComparison.Cotracts;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison.Implementation
{
    public class MathNetCosineCalculator: ICosineDistanceCalculator
    {

        public MathNetCosineCalculator() 
        {
            
        }

        public float GetCosineDistance(float[] vector1, float[] vector2)
        {
            return Distance.Cosine(vector1, vector2);
        }

        public double GetCosineDistance(double[] vector1, double[] vector2)
        {
            return Distance.Cosine(vector1, vector2);
        }
    }
}
