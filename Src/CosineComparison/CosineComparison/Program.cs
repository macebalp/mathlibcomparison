using CosineComparison.Cotracts;
using CosineComparison.Implementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            float[][] workingMatrix = MatrixGenerator.GetRandomVectors(75, 10000);
            float[][] workingMatrix2 = MatrixGenerator.GetRandomVectors(75, 1000);

            ICosineDistanceCalculator calculator; 
            //calculator = new PlainCosineCalculator();
            calculator = new PlainCosineCalculator();

            IMultiCosineDistanceCalculator multiCalculator;
            multiCalculator = new BaseParallelCosineCalculator(calculator);
            
            Stopwatch st = new Stopwatch();
            Console.WriteLine("Testing with matrices 1({0},{1}) 2({2},{3})", workingMatrix[0].Length, workingMatrix.Length, workingMatrix2[0].Length, workingMatrix2.Length);
            st.Start();
            var result = multiCalculator.GetCosineDistance(workingMatrix, workingMatrix2);
            st.Stop();

            Console.WriteLine("Elapsed time is: {0}", st.Elapsed);

            multiCalculator = new BaseMultiCosineCalculator(calculator);
            var result2 = multiCalculator.GetCosineDistance(workingMatrix, workingMatrix2);

            
            Console.ReadLine();
        }
    }
}
