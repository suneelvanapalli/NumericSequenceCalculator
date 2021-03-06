﻿using System;
using NumericSequenceCalculator.BusinessServices;
using System.Collections.Generic;
using NUnit.Framework;

namespace NumericSequenceCalculator.Tests
{
    [TestFixture]
    public class SequenceServiceTest
    {
        [Test]
        public void GetAllNumbersTest()
        {
            var service = new SequenceService();
            var numbers = service.GetAllNumbers(5);
             
            Assert.AreEqual(5, numbers.Count);
        }

        [Test]
        public void GetAllOddNumbersTest()
        {
            var service = new SequenceService();
            var numbers = service.GetAllOddNumbers(5);
            //1,3,5
            Assert.AreEqual(3, numbers.Count);
        }

        [Test]
        public void GetAllEvenNumbersTest()
        {
            var service = new SequenceService();
            var numbers = service.GetAllEvenNumbers(5);
            //2,4

            Assert.AreEqual(2, numbers.Count);
            Assert.IsInstanceOf<List<int>>(numbers);

        }

        [Test(Description = "To test count of numbers in sequence for all numbers sequence")]
        public void GetAllNumbersCountTest()
        {
            var service = new SequenceService();
            var numbers = service.GetAllNumbers(10);
            //2,4

            Assert.AreEqual(11, numbers.Count);
        }

        [Test( Description = "To verify whether it is including the input number")]
        public void GetEvenCountTest()
        {
            var service = new SequenceService();
            var numbers = service.GetAllEvenNumbers(10);
            
            Assert.AreEqual(10, numbers[numbers.Count-1]);
        }

        //[TestMethod]
        //[Description("To verify that it is including the input fibonacci number as well")]
        //public void GetFibonacciSequenceTest()
        //{
        //    var service = new SequenceService();
        //    var numbers = service.GetAllFibonacciNumbers(13);

        //    Assert.AreEqual(13, numbers[numbers.Count - 1]);
        //}

        //[TestMethod]
        //public void GetNumbersInCustomFormat()
        //{
        //    var service = new SequenceService();
        //    var numbers = service.GetNumbersInCustomFormat(5);


        //    Assert.AreEqual(5, numbers.Count);
        //    Assert.IsInstanceOfType(numbers, typeof(List<string>));

        //}


        //[TestMethod]
        //public void GetAllFibonacciNumbers()
        //{
        //    var service = new SequenceService();
        //    var numbers = service.GetAllFibonacciNumbers(10);


        //    //Assert.AreEqual(5, numbers.Count);
        //    Assert.IsInstanceOfType(numbers, typeof(List<int>));

        //}
    }
}
