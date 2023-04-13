using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace PresentationLayer_WebUi_.Controllers
{
    [Authorize]
    public class FavoriteProductController : Controller
    {
        private readonly IFavoriteProductService favoriteProductService;
        private readonly UserManager<ApplicationUser> userManager;

        public FavoriteProductController(IFavoriteProductService _favoriteProductService,
            UserManager<ApplicationUser> _userManager)
        {
            favoriteProductService = _favoriteProductService;
            userManager = _userManager;
        }
        // GET: FavoriteProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FavoriteProductController/Details/5
        public ActionResult FavoriteForUser()
        {
            string userid = userManager.GetUserId(User);
            return View(favoriteProductService.GetAllForUser(userid));
        }
        // POST: FavoriteProductController/Create
        public ActionResult AddToFavorite(int id)
        {
            try
            {
                string userid = userManager.GetUserId(User);
                var hasAdded = favoriteProductService.GetIFAddToFavoriteProduct(id,userid);
                if (hasAdded==null)
                {
                    FavoriteProductVM favoriteProductVM = new FavoriteProductVM();
                    favoriteProductVM.userid = "1";
                    favoriteProductVM.productid = id;
                    favoriteProductService.Insert(favoriteProductVM);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    favoriteProductService.Delete(hasAdded.id);
                    return RedirectToAction("Index","Home");
                }
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
                favoriteProductService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
