using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison.Cotracts
{
    public interface ICosineDistanceCalculator
    {
        float GetCosineDistance(float[] vector1, float[] vector2);
        double GetCosineDistance(double[] vector1, double[] vector2);
    }
}
