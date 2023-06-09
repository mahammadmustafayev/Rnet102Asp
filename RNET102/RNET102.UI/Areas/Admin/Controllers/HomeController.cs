using Microsoft.AspNetCore.Mvc;

namespace RNET102.UI.Areas.Admin.Controllers;
[Area("Admin")]
public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
