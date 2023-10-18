// Shared Folder in Views will contain all partial views 
// and _Layout is the master page of your app
// And whatever inside Views --> HomeController, is imported into that.
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BulkyBookWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        // For example if you type https://localhost:7230/Home/index , it will 
        // execute this method which returns View() which is placed in
        // Views --> HomeController --> index.cshtml
        // IActionResult is a generic type that implements all of the other return types
        // ex :  ViewResult and PageResult if you want to especifically declare
        // Action result is a result of action methods/pages or 
        // return types pf action methods/page handlers
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:7230/Home/privacy
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