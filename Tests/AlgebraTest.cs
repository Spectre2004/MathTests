using MathLibraryTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class AlgebraTest
    {
        [TestMethod]
        public void SumArrayTest12345()
        {
            double res = Algebra.SumArray(new double[5] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void SumArrayTest01234()
        {
            double res = Algebra.SumArray(new double[5] { -1, 1, 2, 3, 0 });

            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void MaxFromArrayTest12345()
        {
            double res = Algebra.MaxFromArray(new double[5] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void MaxFromArrayTest11111()
        {
            double res = Algebra.MaxFromArray(new double[5] { 1, 1, 1, 1, 1 });

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void MaxFromArrayTest01010()
        {
            double res = Algebra.MaxFromArray(new double[5] { 0, 1, 0, 1, 0 });

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void MaxFromArrayTest()
        {
            double res = Algebra.MaxFromArray(new double[5]);

            Assert.AreEqual(null, res);
        }
        [TestMethod]
        public void MinFromArrayTest12345()
        {
            double res = Algebra.MinFromArray(new double[5] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void MinFromArrayTest01234()
        {
            double res = Algebra.MinFromArray(new double[5] { -1, 0, 1, 2, 3 });

            Assert.AreEqual(-1, res);
        }
        [TestMethod]
        public void AvgArrayTest12345()
        {
            double res = Algebra.MinFromArray(new double[5] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void AvgArrayTest01010()
        {
            double res = Algebra.MinFromArray(new double[5] { 0, 1, 0, 1, 0 });

            Assert.AreEqual(2 / 5, res);
        }
        [TestMethod]
        public void AvgArrayTestNegative1010()
        {
            double res = Algebra.MinFromArray(new double[5] { -10, 10, 0, 0, 0 });

            Assert.AreEqual(0, res);
        }
        //geometry
        [TestMethod]
        public void TrianglAareaTest42()
        {
            double res = Geometry.TrianglAarea(4, 2);

            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void TrianglAareaTest333()
        {
            double res = Geometry.TrianglAarea(3, 3, 3);

            Assert.AreEqual(15.1875, res);
        }
        [TestMethod]
        public void TrianglAareaTest100_1_1()
        {
            double res = Geometry.TrianglAarea(100, 1, 1);

            Assert.AreEqual(null, res);
        }
        [TestMethod]
        public void TrianglAareaTest000()
        {
            double res = Geometry.TrianglAarea(0, 0, 0);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void SquareAreaTest5()
        {
            double res = Geometry.SquareArea(5);

            Assert.AreEqual(25, res);
        }
        [TestMethod]
        public void SquareAreaTest0()
        {
            double res = Geometry.SquareArea(0);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void SquareAreaTest_neg1()
        {
            double res = Geometry.SquareArea(-1);

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void SquareAreaTest_1()
        {
            double res = Geometry.SquareArea(1);

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void RectangleAreaTest45()
        {
            double res = Geometry.RectangleArea(4, 5);

            Assert.AreEqual(20, res);
        }
        [TestMethod]
        public void RectangleAreaTest_0_1()
        {
            double res = Geometry.RectangleArea(0, 1);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void RectangleAreaTest_neg1_1()
        {
            double res = Geometry.RectangleArea(-1, 1);

            Assert.AreEqual(null, res);
        }
        [TestMethod]
        public void RhombusAreaTest4_4()
        {
            double res = Geometry.RectangleArea(4, 4);

            Assert.AreEqual(8, res);
        }
        [TestMethod]
        public void RhombusAreaTest0_1()
        {
            double res = Geometry.RectangleArea(0, 1);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void RhombusAreaTest_neg1_1()
        {
            double res = Geometry.RectangleArea(-1, 1);

            Assert.AreEqual(-1 / 2, res);
        }
        [TestMethod]
        public void RhombusAreaTest_0_0()
        {
            double res = Geometry.RectangleArea(0, 0);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void CircleAreaTest4()
        {
            double res = Geometry.CircleArea(4);

            Assert.AreEqual(50.24, res);
        }
        [TestMethod]
        public void CircleAreaTest0()
        {
            double res = Geometry.CircleArea(4);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void CircleAreaTest_neg1()
        {
            double res = Geometry.CircleArea(-1);

            Assert.AreEqual(null, res);
        }
        [TestMethod]
        public void CircleAreaTest_01()
        {
            double res = Geometry.CircleArea(0.1);

            Assert.AreEqual(0.01, res);
        }
        //Trigonometry
        [TestMethod]
        public void SinTest_1()
        {
            double res = Trigonometry.Sin(1);

            Assert.AreEqual(Math.Sin(1), res);
        }
        [TestMethod]
        public void SinTest_60()
        {
            double res = Trigonometry.Sin(60);

            Assert.AreEqual(Math.Sin(60), res);
        }
        [TestMethod]
        public void SinTest_neg1()
        {
            double res = Trigonometry.Sin(-1);

            Assert.AreEqual(Math.Sin(-1), res);
        }
        [TestMethod]
        public void SinTest_0()
        {
            double res = Trigonometry.Sin(0);

            Assert.AreEqual(Math.Sin(0), res);
        }
        [TestMethod]
        public void SinTest_neg60()
        {
            double res = Trigonometry.Sin(-60);

            Assert.AreEqual(Math.Sin(-60), res);
        }
        [TestMethod]
        public void SinTest_neg40()
        {
            double res = Trigonometry.Sin(-60);

            Assert.AreEqual(Math.Sin(-60), res);
        }
        [TestMethod]
        public void CosTest_neg1()
        {
            double res = Trigonometry.Cos(-1);

            Assert.AreEqual(Math.Cos(-1), res);
        }
        [TestMethod]
        public void CosTest_0()
        {
            double res = Trigonometry.Cos(0);

            Assert.AreEqual(Math.Cos(0), res);
        }
        [TestMethod]
        public void CosTest_1()
        {
            double res = Trigonometry.Cos(1);

            Assert.AreEqual(Math.Cos(1), res);
        }
        [TestMethod]
        public void CosTest_60()
        {
            double res = Trigonometry.Cos(60);

            Assert.AreEqual(Math.Cos(60), res);
        }
        [TestMethod]
        public void CosTest_neg60()
        {
            double res = Trigonometry.Cos(-60);

            Assert.AreEqual(Math.Cos(-60), res);
        }
        [TestMethod]
        public void TgnTest_0()
        {
            double res = Trigonometry.Tgn(0);

            Assert.AreEqual(Math.Tan(0), res);
        }
        [TestMethod]
        public void TgnTest_1()
        {
            double res = Trigonometry.Tgn(1);

            Assert.AreEqual(Math.Tan(1), res);
        }
        [TestMethod]
        public void TgnTest_neg1()
        {
            double res = Trigonometry.Tgn(-1);

            Assert.AreEqual(Math.Tan(-1), res);
        }
        [TestMethod]
        public void TgnTest_60()
        {
            double res = Trigonometry.Tgn(60);

            Assert.AreEqual(Math.Tan(60), res);
        }
        [TestMethod]
        public void TgnTest_neg60()
        {
            double res = Trigonometry.Tgn(-60);

            Assert.AreEqual(Math.Tan(-60), res);
        }
        [TestMethod]
        public void CtgTest_neg1()
        {
            double res = Trigonometry.Ctg(-1);

            Assert.AreEqual(Math.Tanh(-1), res);
        }
        [TestMethod]
        public void CtgTest_60()
        {
            double res = Trigonometry.Ctg(60);

            Assert.AreEqual(Math.Tanh(60), res);
        }
        [TestMethod]
        public void CtgTest_neg60()
        {
            double res = Trigonometry.Ctg(-60);

            Assert.AreEqual(Math.Tanh(-60), res);
        }
        [TestMethod]
        public void CtgTest_1()
        {
            double res = Trigonometry.Ctg(1);

            Assert.AreEqual(Math.Tanh(1), res);
        }
    }
}
