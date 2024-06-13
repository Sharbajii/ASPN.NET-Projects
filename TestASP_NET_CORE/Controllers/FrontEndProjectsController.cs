using Microsoft.AspNetCore.Mvc;

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
    }
}
