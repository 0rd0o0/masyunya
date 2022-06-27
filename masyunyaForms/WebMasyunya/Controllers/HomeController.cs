using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using masyunyaForms;

namespace WebMasyunya.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "multiplex", Text ="умножить на" },
                new SelectListItem() { Value = "plus", Text ="плюс" },
                new SelectListItem() { Value = "minus", Text ="минус" },
                new SelectListItem() { Value = "devision", Text ="делить на" },
                new SelectListItem() { Value = "arif", Text ="Арифметическое среднее" },
                new SelectListItem() { Value = "geom", Text ="Геометрическое среднее" },
                new SelectListItem() { Value = "power", Text ="в степени" },
                new SelectListItem() { Value = "ex", Text ="e^x (второй аргумент игнорируется)" },
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
            double firstNumber,
            double secondNumber,
            string operation)
        {
            double result = 0;
            if (operation == "ex")
            {
                IOneArgumentCalculator calculator =
                    OneArgumentFactory.CreateCalculator(operation);
                result = calculator.Calculate(firstNumber);
            }
            else
            {
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator(operation);
                result = calculator.Calculate(firstNumber, secondNumber);
            }
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "multiplex", Text ="Умножить" },
                new SelectListItem() { Value = "plus", Text ="Плюс" },
                new SelectListItem() { Value = "minus", Text ="Минус" },
                new SelectListItem() { Value = "devision", Text ="Деление" },
                new SelectListItem() { Value = "arif", Text ="Арифметическое среднее" },
                new SelectListItem() { Value = "geom", Text ="Геометрическое среднее" },
                new SelectListItem() { Value = "power", Text ="Степень" },
                new SelectListItem() { Value = "ex", Text ="e^x" },
            };
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}