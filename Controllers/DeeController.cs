using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flipkart.Controllers
{
    public class DeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
