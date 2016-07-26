using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Controllers //FizzBuzz Project Name
{
    public class FizzBuzzController : Controller // Filename
    {
        private string ToFizzBuzz(int value)
        {
            var isDivisibleByFive = value % 5 == 0;
            var isDivisibleByThree = value % 3 == 0;

            if (isDivisibleByThree && isDivisibleByFive) return "FizzBuzz";
            if (isDivisibleByThree) return "Fizz";
            if (isDivisibleByFive) return "Buzz";

            return value.ToString();
        }

        public ActionResult Index()
        {
            var model = Enumerable.Range(1, 100).Select(ToFizzBuzz).ToArray();
            return View(model);
        }
    }
}