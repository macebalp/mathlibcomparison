using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CosineComparison.Implementation;
using System.Linq;

namespace CosineComparisonTest.Implementation
{
    [TestClass]
    public class PlainCosineCalculatorTest
    {
        Random randomizer = new Random();

        PlainCosineCalculator sut;

        [TestInitialize]
        public void Initialize()
        {
            sut = new PlainCosineCalculator();
        }

        [TestMethod]
        public void GetCosineDistance_Equal_1()
        {
            float[] vect1 = Enumerable.Range(1, randomizer.Next(1,10)).Select(i => randomizer.Next(10) * 0.001f).ToArray();
            float[] vect2 = vect1;

            float result = sut.GetCosineDistance(vect1, vect2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetCosineDistance_DifferentNorm_1()
        {
            float[] vect1 = Enumerable.Range(1, randomizer.Next(1, 10)).Select(i => randomizer.Next(10) * 0.001f).ToArray();
            float[] vect2 = vect1.Select(x => x*2).ToArray();

            float result = sut.GetCosineDistance(vect1, vect2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetCosineDistance_Orthogonal_0()
        {
            float[] vect1 = new float[] { 0, 2 };
            float[] vect2 = new float[] { 2, 0 }; ;

            float result = sut.GetCosineDistance(vect1, vect2);

            Assert.AreEqual(0, result);
        }
    }
}
