using Microsoft.AspNetCore.Mvc;

namespace ImtahanEbusiness.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
