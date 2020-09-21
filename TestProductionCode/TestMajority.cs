using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductionCode;


namespace TestProductionCode
{
    [TestClass]
    public class TestMajority
    {
        [TestMethod]
        public void TestFalse()
        {
            // a) create object
            Majority m = new Majority();

            // b) setup
            int[] input = { 1, 2, 3, 1, 2, 3 };
            bool expectedResult = false;
            bool actualResult;

            // c) act
            actualResult = m.HasMajority(input);

            // d) assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestTrue()
        {
            Majority m = new Majority();
            int[] input = { 1, 2, 2 };

            Assert.IsTrue(m.HasMajority(input));
        }

        [TestMethod]
        public void Test3()
        {
            Majority m = new Majority();
            int[] input = { 1, 2, 2, 1 };

            Assert.IsFalse(m.HasMajority(input));
        }

        [TestMethod]
        public void TestEmpty()
        {
            Majority m = new Majority();
            int[] input = {};

            Assert.ThrowsException<Exception>(() => m.HasMajority(input));
        }

        [TestMethod]
        [Timeout(4000)]
        public void TestPerformance()
        {
            // a) create objects
            int N = 100000000;
            Majority m = new Majority();

            // b) setup
            int[] input = new int[N];
            Random r = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = r.Next(100);

            // c) act
            m.HasMajority(input);
        }
    }
}
