using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductionCode;

namespace TestProductionCode
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 1, 2 };
            Assert.IsTrue(af.IsUnique(a));

            int[] b = { };
            Assert.IsTrue(af.IsUnique(b));


        }

        [TestMethod]
        public void TestMethod2()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 1, 1 };
            Assert.IsFalse(af.IsUnique(a));


        }
        [TestMethod]
        public void TestMethod3()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 1, 2, 1 };
            Assert.IsFalse(af.IsUnique(a));


        }


        [TestMethod]
        public void TestMethod4()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 1, 2, 1 };
            Assert.IsFalse(af.IsUnique(a));


        }

        [TestMethod]
        public void TestException()
        {
            ArrayFunctions af = new ArrayFunctions();

            Assert.ThrowsException<Exception>(() => af.IsUnique(null));

        }

        
    }
}
