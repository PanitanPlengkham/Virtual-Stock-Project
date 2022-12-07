using Microsoft.AspNetCore.Mvc;

namespace Virtual_stock.Controllers
{
	public class VirtualStockController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
