using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flipkart.Controllers
{
    public class DairyMilkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
