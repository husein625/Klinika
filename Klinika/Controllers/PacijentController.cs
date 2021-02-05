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
    public class PacijentController : Controller
    {
        private IPacijentRepository _pacijentRepository;
        private ApplicationDbContext _applicationDbContext;
        public PacijentController(IPacijentRepository pacijentRepository, ApplicationDbContext applicationDbContext)
        {
            _pacijentRepository = pacijentRepository;
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var obj = _pacijentRepository.GetAll(); 
            return View(obj);
        }

        public List<Pacijent> GetEmpList()
        {
            var empList = new List<Pacijent>()
    {
         new Pacijent { Id=1, ImePrezime="Manas"},
         new Pacijent { Id=2, ImePrezime="Tester"}
    };

            return empList;
        }
        [HttpGet]
        public ActionResult Create()
        {

           // ViewBag.items = new SelectList(_spolRepository.GetAll(), "SpolID");
               ViewData["SpolID"] = new SelectList(_applicationDbContext.Spol, "Id", "Naziv");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pacijent pacijent)
        {
            if (ModelState.IsValid)
            {
                _pacijentRepository.Insert(pacijent);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["SpolID"] = new SelectList(_applicationDbContext.Spol, "Id", "Naziv");
            var pacijent = await  _applicationDbContext.Pacijent.FindAsync(id);
           return View(pacijent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pacijent pacijent, int pacijentId)
        {
            if (ModelState.IsValid)
            {
                _pacijentRepository.Update(pacijent, pacijentId);
               return RedirectToAction(nameof(Index));
            }
            ViewData["SpolID"] = new SelectList(_applicationDbContext.Spol, "Id", "Naziv", pacijent.SpolID);
           return View("Index");
           
        }

        public async Task<IActionResult> Delete(int id)
        {
            var pacijent = await _applicationDbContext.Pacijent.FindAsync(id);
            return View(pacijent);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _pacijentRepository.Delete(id);
            return RedirectToAction(nameof(Index));

        }

    }
}
