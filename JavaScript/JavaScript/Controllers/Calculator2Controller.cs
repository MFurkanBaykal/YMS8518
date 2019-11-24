using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JavaScript.Controllers
{
    public class Calculator2Controller : Controller
    {
        public IActionResult Calculator2()
        {
            return View();
        }
    }
}