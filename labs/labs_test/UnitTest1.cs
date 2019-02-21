using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_113_Arraylist;

namespace labs_test
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}
        [TestMethod]
        public void Lab113ArrayListTest()
        {
            //arrange
            var expected = -10;
            var instanceLab113 = new Arraylist();
            //act
            var actual = instanceLab113.arraylistmethod(10, 20, 30, 40);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
