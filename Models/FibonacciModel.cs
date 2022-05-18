using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fibonacci.Models
{
    public class FibonacciModel
    {
        public int FibonacciLength { get; set; }
    }
    public class FibonacciOperationsModel
    {
        [Display(Name = "Sum of the even-valued terms")]
        public int SumOfEvens { get; set; }

        [Display(Name = "Fibonacci Series")]
        public int[] FibonacciSeries { get; set; }

    }
}