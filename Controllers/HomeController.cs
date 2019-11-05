using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using dojo_survey.Models;
using Microsoft.AspNetCore.Mvc;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            Console.WriteLine("*************************************The Index method is running*************************************");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Survey mySurvey)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("*************************************The Create method is running*************************************");
                // return RedirectToAction("Result", new { survey = mySurvey });
                return View ("result", mySurvey);
            }
            else
            {
                Console.WriteLine("*************************************The FailedResult method is running*************************************");
                return View("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}