using Microsoft.AspNetCore.Mvc;

namespace TestASP_NET_CORE.Controllers
{
	public class StuffController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Nav()
		{
			ViewData["Title"] = "Nav Page";
			return View();
		}

		public IActionResult Links()
		{
			ViewData["Title"] = "Links Page";
			return View();
		} 
	}
}
