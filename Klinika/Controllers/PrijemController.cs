using Klinika.DAL;
using Klinika.DAL.Models;
using Klinika.DAL.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Reporting;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AspNetCore.Reporting.ReportExecutionService;
using System.IO;
using System.Reflection;
using WindowsFormsApp3;

namespace Klinika.Controllers
{
    public class PrijemController : Controller
    {
        private IPrijemRepository _prijemRepository;
        private ApplicationDbContext _applicationDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PrijemController(IPrijemRepository prijemRepository, ApplicationDbContext applicationDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _prijemRepository = prijemRepository;
            _applicationDbContext = applicationDbContext;
            _webHostEnvironment = webHostEnvironment;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


        }
        public IActionResult Index(DateTime? startdate = null, DateTime? enddate = null)
        {
            if (startdate != null && enddate != null)
            {



                var rangeData = _applicationDbContext.Prijem.Include(e => e.Ljekar).Include(a => a.Pacijent).Where(x => x.DatumVrijeme >= startdate && x.DatumVrijeme <= enddate).ToList();

                return View(rangeData);
            }


            var obj = _prijemRepository.GetAll();
            return View(obj);


        }




        [HttpGet]
        public ActionResult Create()
        {
            ViewData["PacijentID"] = new SelectList(_applicationDbContext.Pacijent, "Id", "ImePrezime");
            ViewData["LjekarID"] = new SelectList(_applicationDbContext.Ljekar.Where(x => x.TitulaID == 1), "Id", "Ime", "Prezime", "Sifra");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prijem prijem)
        {
            if (ModelState.IsValid)
            {
                _prijemRepository.Insert(prijem);
                return RedirectToAction("Index");
            }
            return View();
        }



        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["PacijentID"] = new SelectList(_applicationDbContext.Pacijent, "Id", "ImePrezime");
            ViewData["LjekarID"] = new SelectList(_applicationDbContext.Ljekar.Where(x => x.TitulaID == 1), "Id", "Ime", "Prezime", "Sifra");
            var prijem = await _applicationDbContext.Prijem.FindAsync(id);
            return View(prijem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Prijem prijem, int prijemId)
        {
            ModelState.Remove("DatumVrijeme");
            if (ModelState.IsValid)
            {
                _prijemRepository.Update(prijem, prijemId);
                return RedirectToAction(nameof(Index));
            }
            ViewData["PacijentID"] = new SelectList(_applicationDbContext.Pacijent, "Id", "ImePrezime", prijem.PacijentID);
            ViewData["LjekarID"] = new SelectList(_applicationDbContext.Ljekar.Where(x => x.TitulaID == 1), "Id", "Ime", prijem.LjekarID);
            return View();

        }




        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            await _prijemRepository.Delete(id);
            return RedirectToAction("Index");

        }





        public IActionResult Print()
        {



            string mimetype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\Prijem.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prijemId", "Struktuirani podaci o prijemu");
            LocalReport lr = new LocalReport(path);
            var result = lr.Execute(RenderType.Pdf, extension, parameters, mimetype);
            return File(result.MainStream, "application/pdf");

        }













    }




}
