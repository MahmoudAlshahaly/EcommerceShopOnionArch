using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer_WebUi_.Controllers
{
    [Authorize(Roles="Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IFavoriteProductService favoriteProductService;
        private readonly IBrandService brandService;
        private readonly ICategoryService categoryService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<ApplicationUser> userManager;

        public ProductController(
            IProductService _productService,
            IFavoriteProductService _favoriteProductService,
            IBrandService _brandService,
            ICategoryService _categoryService,
            IWebHostEnvironment _webHostEnvironment,
            UserManager<ApplicationUser> _userManager)
        {
            productService = _productService;
            favoriteProductService = _favoriteProductService;
            brandService = _brandService;
            categoryService = _categoryService;
            webHostEnvironment = _webHostEnvironment;
            userManager = _userManager;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(productService.GetAll());
        }
        [Authorize(Roles ="User")]
        public ActionResult Search(string name)
        {
            return View(productService.GetAll(name));
        }
        [HttpGet]
        public IActionResult DetailsForAdmin(int id)
        {
            return  View(productService.GetByID(id));
        }
        // GET: ProductController/Details/5
        [HttpGet]
        [Authorize(Roles ="User")]
        public ActionResult Details(int id)
        {
            ProductVM productVM = productService.GetByID(id);
            if (productVM.Reviews.Count() > 0)
            {
                ViewData["Rating"] = productVM.Reviews.Select(a => a.rate).Sum() / productVM.Reviews.Count();
            }
            string UserID = userManager.GetUserId(User);
            var ProductInFavorite = favoriteProductService.GetIFAddToFavoriteProduct(id, UserID);
            if (ProductInFavorite == null)
            {
                return View(productVM);
            }
            productVM.isFavorite = true;
            return View(productVM);
        }
        // GET: ProductController/Create
        public ActionResult Create()
        {
            ProductVM productVM = new ProductVM();
            productVM.Brands =brandService.GetAll().ToList();
            productVM.Categories =categoryService.GetAll().ToList();
            return View(productVM);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductVM productVM)
        {
            try
            {
                string filename = string.Empty;
                if (productVM.files != null)
                {
                    for (int i = 0; i < productVM.files.Count; i++)
                    {
                        //string a = Path.GetRandomFileName().Replace(".", "") + Path.GetExtension(filename);
                        string uploads = Path.Combine(webHostEnvironment.WebRootPath, "img");
                        filename = productVM.files[i].FileName;
                        string fullpath = Path.Combine(uploads, filename);
                        productVM.files[i].CopyTo(new FileStream(fullpath, FileMode.Create));
                        productVM.imageurl = filename;
                        productVM.ProductImage.Add(new ProductImageVM { imageurl = filename });
                    }
                }
                productService.Insert(productVM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(productVM);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ProductVM productVM = new ProductVM();
            productVM = productService.GetByID(id);
            productVM.Categories =categoryService.GetAll().ToList();
            productVM.Brands =brandService.GetAll().ToList();
            return View(productVM);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductVM productVM)
        {
            try
            {
                var protVM = productService.GetByIDNoTracking(productVM.id);
                string filename = string.Empty;
                if (productVM.files != null)
                {
                    for (int i = 0; i < productVM.files.Count; i++)
                    {
                        string uploads = Path.Combine(webHostEnvironment.WebRootPath, "img");
                        filename = productVM.files[i].FileName;
                        string fullpath = Path.Combine(uploads, filename);


                        string oldfilename ="";
                        foreach (var item in protVM.ProductImage)
                        {
                            oldfilename = item.imageurl;
                        }
                        if (protVM.imageurl != null)
                        {
                            string fulloldpath = Path.Combine(uploads, oldfilename);
                            if (fullpath != oldfilename)
                            {
                                System.IO.File.Delete(fulloldpath);
                                productVM.files[i].CopyTo(new FileStream(fullpath, FileMode.Create));
                            }
                        }
                        productVM.imageurl = filename;
                    }
                }
                productService.Update(productVM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                productService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
