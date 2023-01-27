using Core.Entities;
using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace ImtahanEbusiness.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class teamController : Controller
    {
        private AppDbContext _appDbContext;

        public teamController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.teams);
        }
        public  IActionResult Create( )
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(team item)
        {
          if(!ModelState.IsValid) return View(item);
          await _appDbContext.teams.AddAsync(item);
            await _appDbContext.SaveChangesAsync();
          return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult>  Detail(int id)
        { 
            var model = await _appDbContext.teams.FindAsync(id);

            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
