using Microsoft.AspNetCore.Mvc;

namespace RNET102.UI.ViewComponents;


public class BlogViewComponent : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		var blogs = Models.SeedData.BlogsSeedData;
		return View(model:blogs);
	}
}
