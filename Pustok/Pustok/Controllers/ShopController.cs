using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pustok.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Pustok.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            ShopViewModel shopVW = new ShopViewModel
            {
                Genre = _context.Genres.ToList(),
                book = _context.Book.ToList(),
               
            };

            return View(shopVW);
        }
    }
}
