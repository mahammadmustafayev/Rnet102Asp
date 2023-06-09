using Microsoft.AspNetCore.Mvc;
using RNET102.UI.Seeds;

namespace RNET102.UI.ViewComponents;


public class BlogViewComponent : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		
		return View();
	}
}
