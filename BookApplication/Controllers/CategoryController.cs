using BookApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookApplication.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookContext _context;

        public CategoryController(BookContext context)
        {
            _context = context;
        }

        public IActionResult DetailsBooks(int id)
        {
            var category = _context.Categories.Include(c => c.Books).FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
    }
}

