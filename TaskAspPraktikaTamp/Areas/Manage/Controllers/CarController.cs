using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TaskAspPraktikaTamp.DAL;
using TaskAspPraktikaTamp.Models;

namespace TaskAspPraktikaTamp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CarController : Controller
    {
        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Car> cars = _context.Cars.ToList();
            return View(cars);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {

            return View();
        }
    }
}
