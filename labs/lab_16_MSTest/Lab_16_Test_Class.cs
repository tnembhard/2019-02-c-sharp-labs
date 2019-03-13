using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_16_NUnit_XUNIT_Tests;
using System;

namespace lab_16_MSTest
{
    [TestClass]
    public class Lab_16_Test_Class
    {
        [TestInitialize]
        public void Initialise()
        {
            Console.WriteLine("Initialising Tests");
        }
        
        [TestMethod]
        public void TestLab16UsingMSTest()
        {
            // arrange
            var expected = 216.0;
            var instance01 = new TestMeNow();
            // act
            var actual = instance01.TestThisMethodWokrs(2, 3, 3);
            // assert
            Assert.AreEqual(expected,actual);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine("Cleaning up after codes have run");
        }
    }
}
