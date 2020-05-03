using System.Diagnostics;
using System.Linq;
using AdminPortal.HaloMysql;
using AdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.Controllers
{
    public class HomeController : Controller
    {
        readonly haloContext _db = new haloContext();


        public IActionResult Index()
        {
            return View();
        }

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
