using Klinika.DAL;
using Klinika.DAL.Models;
using Klinika.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klinika.Controllers
{
    public class NalazController : Controller
    {
        private INalazRepository _nalazRepository;
        private ApplicationDbContext _applicationDbContext;
        public NalazController(INalazRepository nalazRepository, ApplicationDbContext applicationDbContext)
        {
            _nalazRepository = nalazRepository;
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index(int id)
        {
            ViewBag.prijemId = id;
            //var obj = _applicationDbContext.Nalaz.Include(e => e.Prijem).Where(e => e.PrijemID ==id);
            var obj = _applicationDbContext.Nalaz.Where(e => e.PrijemID == id);
            return View(obj);
        }


        [HttpPost]
        public ContentResult AjaxMethod(string name)
        {
            string currentDateTime = string.Format("Hello {0}.\nCurrent DateTime: {1}", name, DateTime.Now.ToString());
            return Content(currentDateTime);
        }


        [HttpGet]
        public IActionResult Create(int? prijemId, string returnUrl)
        {
            //ViewBag.prijemId = id;
            ViewBag.returnUrl = returnUrl;
            // ViewData["PrijemID"] = new SelectList(_applicationDbContext.Prijem.Where(x=> x.Id==id),"Id", "DatumVrijeme");
            ViewBag.PrijemID = new SelectList(_applicationDbContext.Prijem.Where(p => p.Id == prijemId), "Id", "DatumVrijeme");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Opis,DatumVrijeme,PrijemID")] Nalaz nalaz)
        {

            if (ModelState.IsValid)
            {
                _nalazRepository.Insert(nalaz);
               // return RedirectToAction(returnUrl);
                return RedirectToAction("Index", new { ID = nalaz.PrijemID});

                //return RedirectToAction("Index", new { returnUrl =returnUrl  });

            }

            return View("Index");

        }




        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["PrijemID"] = new SelectList(_applicationDbContext.Prijem, "Id", "DatumVrijeme");
            var nalaz = await _applicationDbContext.Nalaz.FindAsync(id);
            return View(nalaz);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Nalaz nalaz, int nalazId)
        {
            if (ModelState.IsValid)
            {
                _nalazRepository.Update(nalaz, nalazId);
                return RedirectToAction("Index", new { ID = nalaz.PrijemID });
            }
            ViewData["PrijemID"] = new SelectList(_applicationDbContext.Prijem, "Id", "DatumVrijeme", nalaz.PrijemID);
            return View("Index");

        }


        public async Task<IActionResult> Delete(int id)
        {
            var nalaz = await _applicationDbContext.Nalaz.FindAsync(id);
            return View(nalaz);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var pId = _applicationDbContext.Nalaz.Where(x => x.Id == id).Select(s => s.PrijemID).SingleOrDefault();

            await _nalazRepository.Delete(id);
            return RedirectToAction("Index", new { id = pId });
            



        }


    }
}
