using Klinika.DAL;
using Klinika.DAL.Models;
using Klinika.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klinika.Controllers
{
    public class LjekarController : Controller
    {
        private ILjekarRepository _ljekarRepository;
        private ApplicationDbContext _applicationDbContext;
        public LjekarController(ILjekarRepository ljekarRepository, ApplicationDbContext applicationDbContext)
        {
            _ljekarRepository = ljekarRepository;
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var obj = _ljekarRepository.GetAll();
            return View(obj);
        }

        [HttpGet]
        public ActionResult Create()
        {

            ViewData["TitulaID"] = new SelectList(_applicationDbContext.Titula, "Id", "Naziv");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ljekar ljekar)
        {
            if (ModelState.IsValid)
            {
                _ljekarRepository.Insert(ljekar);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["TitulaID"] = new SelectList(_applicationDbContext.Titula, "Id", "Naziv");
            var ljekar = await _applicationDbContext.Ljekar.FindAsync(id);
            return View(ljekar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ljekar ljekar, int ljekarId)
        {
            if (ModelState.IsValid)
            {
                _ljekarRepository.Update(ljekar, ljekarId);
                return RedirectToAction(nameof(Index));
            }
            ViewData["TitulaID"] = new SelectList(_applicationDbContext.Titula, "Id", "Naziv", ljekar.TitulaID);
            return View("Index");

        }

        public async Task<IActionResult> Delete(int id)
        {
            var ljekar = await _applicationDbContext.Ljekar.FindAsync(id);
            return View(ljekar);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _ljekarRepository.Delete(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
