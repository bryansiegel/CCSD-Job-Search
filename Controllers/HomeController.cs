using CCSD_Job_Search.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CCSD_Job_Search.Data;
using Microsoft.EntityFrameworkCore;

namespace CCSD_Job_Search.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public async Task<IActionResult> Index()
        {
            return View(await _context.Job.ToListAsync());
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
