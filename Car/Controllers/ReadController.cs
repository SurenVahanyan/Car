using Car.Data;
using Car.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Car.Controllers
{
    public class ReadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReadController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Read()
        {
            var cars = _context.Cars
                .Include(p => p.CarBodies)
                    .ThenInclude(pc => pc.Body)
                .ToList();
            return View(cars);
        }
    





    }
}
