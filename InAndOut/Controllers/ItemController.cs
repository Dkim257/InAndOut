using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objLst = _db.Items;
            return View(objLst);
        }
    }
}