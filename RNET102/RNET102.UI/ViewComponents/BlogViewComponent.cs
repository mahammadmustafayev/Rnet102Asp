using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RNET102.UI.Data;
using RNET102.UI.Models;
using RNET102.UI.Seeds;

namespace RNET102.UI.ViewComponents;


public class BlogViewComponent : ViewComponent
{
	private readonly IDistributedCache _cache;
    private readonly AppDbContext _context;

    public BlogViewComponent(IDistributedCache cache, AppDbContext context)
    {
        _cache = cache;
        _context = context;
    }

    

    public async Task<IViewComponentResult> InvokeAsync()
	{

		List<Blog> result;
		var data = _cache.GetString("blogs_"+DateTime.UtcNow.ToString("yyyyy,MM,dd,HH,mm"));

		if (data is  null)
        {
            string serialized=JsonConvert.SerializeObject(await _context.Blog.ToListAsync());
            var opt = new DistributedCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow=TimeSpan.FromSeconds(30)
            };
            _cache.SetString("blogs_"+ DateTime.UtcNow.ToString("yyyyy,MM,dd,HH,mm"), serialized,opt);
            data= _cache.GetString("blogs_" + DateTime.UtcNow.ToString("yyyyy,MM,dd,HH,mm"));
        }
        result = JsonConvert.DeserializeObject<List<Blog>>(data);
		return View(model:data);
	}
}
