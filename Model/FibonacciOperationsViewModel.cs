using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fibonacci.Model
{
    public class FibonacciViewModel
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Size of Fibonacci Series")]
        public int FibonacciLength { get; set; }
    }
    public class FibonacciOperationsViewModel
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Sum of the even-valued terms")]
        public int SumOfEvens { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Fibonacci Series")]
        public int[] FibonacciSeries { get; set; }

    }
}