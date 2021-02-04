using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);


            return View();
        }

        public IActionResult Details(int id)
        {
            return Ok("You have enttered id = " + id);
        }
    }
}