using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TaskAspPraktikaTamp.DAL;
using TaskAspPraktikaTamp.Models;

namespace TaskAspPraktikaTamp.Areas.Manage.Controllers
{
        [Area("Manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                    return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Category category)
        {
            Category category1 = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (category1 == null) return NotFound();
            category1.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category==null)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
            
        }
    }
}
