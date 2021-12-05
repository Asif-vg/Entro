using Entro.Data;
using Entro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDBContext _context;

        public AboutController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault();
            return View(about);
        }
    }
}
