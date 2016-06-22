using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.BusinessServices;
using System.Collections.Generic;

namespace NumericSequenceCalculator.Tests
{
    [TestClass]
    public class SequenceServiceTest
    {
        [TestMethod]
        public void GetAllNumbersTest()
        {
            var service = new SequenceService();
            var numbers =  service.GetAllNumbers(5);

            Assert.AreEqual(5, numbers.Count);
        }

        [TestMethod]
        public void GetAllOddNumbersTest()
        {
            var service = new SequenceService();
            var numbers = service.GetAllOddNumbers(5);
            //1,3,5
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void GetAllEvenNumbersTest()
        {
            var service = new SequenceService();
            var numbers = service.GetAllEvenNumbers(5);
            //2,4

            Assert.AreEqual(2, numbers.Count);
            Assert.IsInstanceOfType(numbers, typeof(List<int>));

        }

        [TestMethod]
        public void GetNumbersInCustomFormat()
        {
            var service = new SequenceService();
            var numbers = service.GetNumbersInCustomFormat(5);
            

            Assert.AreEqual(5, numbers.Count);
            Assert.IsInstanceOfType(numbers, typeof(List<string>));

        }


        [TestMethod]
        public void GetAllFibonacciNumbers()
        {
            var service = new SequenceService();
            var numbers = service.GetAllFibonacciNumbers(10);


            //Assert.AreEqual(5, numbers.Count);
            Assert.IsInstanceOfType(numbers, typeof(List<int>));

        }
    }
}
