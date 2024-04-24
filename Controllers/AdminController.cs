//using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace CCSD_Job_Search.Controllers
{
    public class AdminController : Controller
    {
        [Route("/Admin/Dashboard")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/Dashboard.cshtml");
        }
    }
}
