using Microsoft.AspNetCore.Mvc;
using Web.Models.EF;

namespace Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class GroupController : Controller
	{
		private readonly TravelAgentContext _context;
		public GroupController(TravelAgentContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		//public async Task<IActionResult> getList()
		//{
		//	var items = _context.Group
		//}
	}
}
