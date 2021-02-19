using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoSurveyWithValidation.Models;

namespace dojoSurveyWithValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("submitted")]
        public IActionResult Submitted()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(Survey yourSurvey)
        {
            if (ModelState.IsValid)
            {
                return View("Submitted",yourSurvey);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
