using Entro.Data;
using Entro.Models;
using Entro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AppDBContext _context;

        public GalleryController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModels homemodels = new HomeModels();
            List<Gallery> gallery = _context.Galleries.Include(a => a.GalleryImage).ToList();
            homemodels.gallery = gallery;
            return View(homemodels);
        }
    }
}
