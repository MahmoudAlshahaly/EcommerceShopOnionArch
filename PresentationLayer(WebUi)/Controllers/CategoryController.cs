using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer_WebUi_.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CategoryController(ICategoryService _categoryService, IWebHostEnvironment _webHostEnvironment)
        {
            categoryService = _categoryService;
            webHostEnvironment = _webHostEnvironment;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(categoryService.GetAll());
        }

        // GET: CategoryController/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            return View(categoryService.GetByID(id));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryVM categoryVM)
        {
            try
            {
                string filename = string.Empty;
                if (categoryVM.file != null)
                {

                    string uploads = Path.Combine(webHostEnvironment.WebRootPath, "img");
                    filename = categoryVM.file.FileName;
                    string fullpath = Path.Combine(uploads, filename);
                    categoryVM.file.CopyTo(new FileStream(fullpath, FileMode.Create));
                    categoryVM.imageurl = filename;

                }
                categoryService.Insert(categoryVM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(categoryService.GetByID(id));
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryVM categoryVM)
        {
            try
            {
                var catVM = categoryService.GetByIDNoTracking(categoryVM.id);
                string filename = string.Empty;
                if (categoryVM.file != null)
                {
                    string uploads = Path.Combine(webHostEnvironment.WebRootPath, "img");
                    filename = categoryVM.file.FileName;
                    string fullpath = Path.Combine(uploads, filename);

                    string oldfilename = catVM.imageurl;
                    if (catVM.imageurl != null)
                    {
                        string fulloldpath = Path.Combine(uploads, oldfilename);

                        if (fullpath != oldfilename)
                        {
                            System.IO.File.Delete(fulloldpath);
                            categoryVM.file.CopyTo(new FileStream(fullpath, FileMode.Create));
                        }
                    }
                    categoryVM.imageurl = filename;
                }

                categoryService.Update(categoryVM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(categoryVM);
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                categoryService.Delete(id);
                return RedirectToAction(nameof(Index));
            } 
            catch
            {
                return View();
            }
        }
    }
}
