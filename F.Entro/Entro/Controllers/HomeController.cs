using Entro.Data;
using Entro.Models;
using Entro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _context;

        public HomeController(AppDBContext context)
        {
            _context = context;
        }
                
        public IActionResult Index()
        {
            ViewBag.Name = "Home";
            HomeModels homemodels = new HomeModels();
            About About = _context.Abouts.FirstOrDefault();
            homemodels.about = About;
            Concert Concert = _context.Concerts.FirstOrDefault();
            homemodels.concert = Concert;
            List<Gallery> Gallery = _context.Galleries.Include(a => a.GalleryImage).ToList();
            homemodels.gallery = Gallery;
            Setting Setting = _context.Settings.FirstOrDefault();
            homemodels.setting = Setting;
            Slider Slider = _context.Sliders.FirstOrDefault();
            homemodels.slider = Slider;
            List<Social> Social = _context.Socials.ToList();
            homemodels.social = Social;

            return View(homemodels);
        }


    }
}
