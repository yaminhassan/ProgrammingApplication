﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebApplication.Models;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public DistanceConverter converter = new DistanceConverter();
        public BMI calculator = new BMI();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        ///  return the page view
        /// </summary>
        /// <returns></returns>
        
        public IActionResult DistanceConverter(DistanceConverter converter)
        {

            return View(converter);


        }



        
        public IActionResult Bmi(BMI calculator)
        {
            
                return View(calculator);
            
        }

        public IActionResult Bmi1(BMI calculator)
        {

            return View();

        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
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
