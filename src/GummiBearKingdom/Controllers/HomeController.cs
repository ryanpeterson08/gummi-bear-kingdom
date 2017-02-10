using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using GummiBearKingdom.Models;




namespace GummiBearKingdom.Controllers
{
    public class HomeController : Controller
    {
        private GummiBearDBContext db = new GummiBearDBContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}
