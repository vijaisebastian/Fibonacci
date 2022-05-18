using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fibonacci.Controllers
{
    public class FibonacciController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerateFibonacci(int FibonacciLength)
        {
            BLayer.FibonacciControllerBL objFibonacciControllerBL = new BLayer.FibonacciControllerBL();
            Model.FibonacciOperationsViewModel objFibonacciOperationsViewMode = new Model.FibonacciOperationsViewModel();

            try
            {
                var result = objFibonacciControllerBL.GetFibonacci(FibonacciLength);
                objFibonacciOperationsViewMode.FibonacciSeries = result.FibonacciSeries;
                objFibonacciOperationsViewMode.SumOfEvens = result.SumOfEvens;
            }
            catch (InvalidOperationException e)
            {
                ModelState.AddModelError(nameof(objFibonacciOperationsViewMode.FibonacciSeries), e.Message );
            }
            catch (Exception e)
            {
                throw;
            }

            return View(objFibonacciOperationsViewMode);
        }
    }
}