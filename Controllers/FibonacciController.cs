using Fibonacci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fibonacci.Controllers
{
    public class FibonacciController : Controller
    {
        // GET: Fibonacci
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerateFibonacci(int FibonacciLength)
        {
            
            return View(GetFibonacci(FibonacciLength));
        }
        public FibonacciOperationsModel GetFibonacci(int p_FibonacciLength)
        {
            int intFirstNum = 1;
            int intSecondNum = 2;
            int[] ArrResult = new int[p_FibonacciLength];
            ArrResult[0] = intFirstNum;
            ArrResult[1] = intSecondNum;
            int[] ArrEven = new int[p_FibonacciLength]; //To store even numbers from fibonacci series
            FibonacciOperationsModel objFibonacciOperationsModel = new FibonacciOperationsModel();
            for (int i = 2; i < p_FibonacciLength; i++)
            {

                ArrResult[i] = intFirstNum + intSecondNum;

                if (CheckFibonacciIsValid(ArrResult[i]))
                {
                    if (CheckDigitIsEven(ArrResult[i]))
                    {
                        ArrEven[i] = ArrResult[i];
                    }
                    intFirstNum = intSecondNum;
                    intSecondNum = ArrResult[i];
                }
                else
                {
                    ModelState.AddModelError(nameof(objFibonacciOperationsModel.FibonacciSeries), "Fibonacci sequence do not exceed four million.Invalid values found.Please try a lower value");
                }
            }
            objFibonacciOperationsModel.FibonacciSeries = ArrResult;
            objFibonacciOperationsModel.SumOfEvens = ArrEven.Sum();
            return objFibonacciOperationsModel;
        }
        public bool CheckDigitIsEven(int p_FibonacciNumber)
        {
            bool blnDigitIsEven = p_FibonacciNumber % 2 == 0 ? true:false;
            return blnDigitIsEven;
        }
        public bool CheckFibonacciIsValid(int p_FibonacciNumber)
        {
            bool blnDigitIsValid = p_FibonacciNumber < 4000000 ? true :false;
            return blnDigitIsValid;
        }


    }
}