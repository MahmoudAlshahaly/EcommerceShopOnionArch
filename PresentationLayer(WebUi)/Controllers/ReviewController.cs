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
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;
        public ReviewController(IReviewService _reviewService)
        {
            reviewService = _reviewService;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(reviewService.GetAll());
        }
        public ActionResult ProductReview(int id)
        {
            return View(reviewService.GetAllByProductID(id));
        }
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReviewVM reviewVM)
        {
            reviewVM.date = DateTime.Now;
            reviewService.Insert(reviewVM);
            return RedirectToAction("index", "Home");
        }
        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(reviewService.GetByID(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ReviewVM reviewVM)
        {
            try
            {
                reviewService.Delete(reviewVM.id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
