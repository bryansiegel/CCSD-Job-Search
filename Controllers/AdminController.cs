//using AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace CCSD_Job_Search.Controllers
{
    public class AdminController : Controller
    {
        [Route("/Admin/Dashboard")]
        [Authorize]
        public IActionResult Index()
        {
            return View("~/Views/Admin/Dashboard.cshtml");
        }
    }
}
