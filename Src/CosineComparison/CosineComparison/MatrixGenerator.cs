using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison
{
    public static class MatrixGenerator
    {
        public static Random rnd = new Random();
        public static float[][] GetRandomVectors(int width, int height) 
        {
            float[][] result = new float[height][];
            for (int i = 0; i < height; i++)
            {
                result[i] = new float[width];
                for (int j = 0; j < width; j++)
                    result[i][j] = (float)rnd.NextDouble();
            }
            return result;
        }
    }
}
