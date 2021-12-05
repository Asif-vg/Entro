using Entro.Data;
using Entro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class ConcertController : Controller
    {
        private readonly AppDBContext _context;

        public ConcertController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Concert concert = _context.Concerts.FirstOrDefault();
            return View(concert);
        }
    }
}
