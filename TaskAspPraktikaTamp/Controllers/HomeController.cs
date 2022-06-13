using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskAspPraktikaTamp.DAL;
using TaskAspPraktikaTamp.Models;
using TaskAspPraktikaTamp.ViewModels;

namespace TaskAspPraktikaTamp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM() {
                Cars=_context.Cars.ToList(),
                Categories=_context.Categories.ToList(),
            };
            return View(homeVM);
        }

        
    }
}
