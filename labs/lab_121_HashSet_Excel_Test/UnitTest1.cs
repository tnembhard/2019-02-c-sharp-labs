using NUnit.Framework;
using lab_121_hash_set_to_excel;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
         * Start a stopwatch
         * Pass 3 numbers to an array
         * Double numbers and pass to a LINKED LIST
         * Double numbers and pass to a HASH SET  *** FASTER THAQN LIST ***
         * Add 15,to each number, then treble numbers and pass to a DICTIONARY
         * Stop the stopwatch.
         * Return the test as a CUSTOM OBJECT CONTAINING
         *  ElapsedTime (integer, will be in milliseconds)
         *  First number
         *  Second number
         *  Third number
         * Test passes if stopwatch time less than time passed in (4th variable) (set to 10 seconds)
         * Not part of the test
         * Output all values to .csv text file and append to existing file.
         *  DATETIME STAMP
         *  INPUT 4 params
         *  OUTPUT 4 params
         * Finally launch excel to read this file using Process.Start...
         */
        [TestCase(10, 20, 30, 10)]
        public void HasSetExcelTest(int a, int b, int c, int d)
        {
            // arrange
            var instance = new HashSetToExcel();            
            // act
            var actual = instance.HashSetToExcelTest(a, b, c).Time;
            // assert
            Assert.IsTrue(actual < d);
        }
    }
}