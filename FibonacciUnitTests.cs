using Fibonacci.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fibonacci
{
    [TestFixture]
    public class FibonacciUnitTests
    {
        FibonacciController objFibonacciController = new FibonacciController();

        [TestCase]
        public void CheckDigitIsEven()
        {
            Assert.AreEqual(true, objFibonacciController.CheckDigitIsEven(2));
            Assert.AreEqual(false, objFibonacciController.CheckDigitIsEven(3));
        }

        [TestCase]
        public void CheckFibonacciIsValid()
        {
            Assert.AreEqual(true, objFibonacciController.CheckFibonacciIsValid(39000));
            Assert.AreEqual(false, objFibonacciController.CheckFibonacciIsValid(4000000));
        }

        [TestCase]
        public void CheckSumOfEvens()
        {
            Assert.AreEqual(8, objFibonacciController.GetFibonacci(5).SumOfEvens);
            Assert.AreEqual(42, objFibonacciController.GetFibonacci(10).SumOfEvens);
            Assert.AreEqual(14326, objFibonacciController.GetFibonacci(20).SumOfEvens);
            Assert.AreEqual(1089152, objFibonacciController.GetFibonacci(30).SumOfEvens);
        }

        [TestCase]
        public void CheckFibonacci()
        {
            int[] ExpectedFibonacci = new int[10] { 1, 2, 3, 5, 8,13, 21, 34, 55, 89 };
            CollectionAssert.AreEqual(ExpectedFibonacci, objFibonacciController.GetFibonacci(10).FibonacciSeries);
        }

        [TestCase]
        public void CheckFibonacciExceedsFourMillion()
        {
            Assert.AreEqual(false, objFibonacciController.CheckFibonacciIsValid(objFibonacciController.GetFibonacci(40).FibonacciSeries[35]));
        }
    }
}