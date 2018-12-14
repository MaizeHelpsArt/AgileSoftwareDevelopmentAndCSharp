using System;
using C7P4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // create an object to test
            Student s = new Student();

            // define a test input and output value
            int score = 90;
            char expectedResult = 'A';

            // run the method under test
            char actualResult = s.GetLetterGrade(score);

            // verify the result
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // create an object to test
            Student s = new Student();

            // define a test input and output value
            for (int score = 90; score <= 100; score++)
            {
                char expectedResult = 'A';

                // run method under test
                char actualResult = s.GetLetterGrade(score);

                // verify
                Assert.AreEqual(expectedResult, actualResult);

            }
        }
    }
}
