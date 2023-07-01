using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Areas.Admin.Controllers
{
	public class DashboardController : Controller
	{

        [Area("Admin")]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
		{
			return View();
		}
	}
}
