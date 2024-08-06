using Microsoft.AspNetCore.Mvc;
using TestASP_NET_CORE.Helper;

namespace TestASP_NET_CORE.Controllers
{
    public class FrontEndProjectsController : Controller
    {
        public IActionResult ResponsiveForm()
        {
            ViewData["Title"] = "Responsive Form";
            return View();
        }
        public IActionResult CssAndHtmlSite()
        {
            ViewData["Title"] = "Avatar | Sharbaji";
            return View();
        }

        public IActionResult ResponsiveGlassSite()
        {
            ViewData["Title"] = "AZ Custom Shoes";
            return View();
        }

        public IActionResult ResponsiveDashboard()
        {
            ViewData["Title"] = "UserManagment Dashboard";
            return View();
        }
        public IActionResult ResponsiveProfileCard()
        {
            ViewData["Title"] = "Profile Card";
            return View();
        }
        public IActionResult AroundTheUniverse()
        {
            ViewData["Title"] = "AroundTheUniverse";
            return View();
        }
        public IActionResult PersonalPortfolio()
        {
            ViewData["Title"] = "Personal Portfolio";
            return View();
        }
        public IActionResult TodoList()
        {
            var dbElementsManipulation = new DBElementsManipulation("DefaultConnectionString");

            dbElementsManipulation.GetTasks();
            ViewData["Title"] = "Todo List";
            return View();
        }
    }
}
