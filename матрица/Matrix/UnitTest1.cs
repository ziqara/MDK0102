using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibMatrix;

namespace MatrixTest
{
    [TestClass]
    public class TMatrix
    {
        [TestMethod]
        public void TestAddMatrix()
        {
            Matrix actual = new Matrix(3);
            List<int> row = new List<int> { 1, 2, 3 };

          
            actual.AddRow(row);

            Matrix exp = new Matrix(3);
            exp.AddRow(new List<int> { 0, 0, 0 });
            exp.AddRow(new List<int> { 0, 0, 0 });
            exp.AddRow(new List<int> { 0, 0, 0 });


            Assert.AreEqual(exp, actual);
        }
    }
}
