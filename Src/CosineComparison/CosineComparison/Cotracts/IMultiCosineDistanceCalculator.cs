using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison.Cotracts
{
    public interface IMultiCosineDistanceCalculator
    {
        float[] GetCosineDistance(float[][] vectors1, float[][] vectors2);

    }
}
