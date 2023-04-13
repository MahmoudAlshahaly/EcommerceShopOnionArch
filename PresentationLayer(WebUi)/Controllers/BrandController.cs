using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer_WebUi_.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BrandController : Controller
    {
        private readonly IBrandService brandService;
        public BrandController(IBrandService _brandService)
        {
            brandService = _brandService;
        }
        // GET: brandController
        public ActionResult Index()
        {
            return View(brandService.GetAll());
        }

        // GET: brandController/Details/5
        public ActionResult Details(int id)
        {
            return View(brandService.GetByID(id));
        }

        // GET: brandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: brandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BrandVM brandVM)
        {
            try
            {
                brandService.Insert(brandVM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: brandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(brandService.GetByID(id));
        }

        // POST: brandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BrandVM brandVM)
        {
            try
            {
                brandService.Update(brandVM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                brandService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
