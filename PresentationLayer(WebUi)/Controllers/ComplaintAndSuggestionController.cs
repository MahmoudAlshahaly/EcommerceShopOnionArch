using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer_WebUi_.Controllers
{
    [Authorize(Roles ="Admin,User")]
    public class ComplaintAndSuggestionController : Controller
    {
        private readonly IComplaintAndSuggestionService complaintAndSuggestionService;
        private readonly UserManager<ApplicationUser> userManager;

        public ComplaintAndSuggestionController(IComplaintAndSuggestionService _complaintAndSuggestionService,
              UserManager<ApplicationUser> _userManager)
        {
            complaintAndSuggestionService = _complaintAndSuggestionService;
            userManager = _userManager;
        }
        // GET: ComplaintAndSuggestionController
        public ActionResult Index()
        {
            return View(complaintAndSuggestionService.GetAll());
        }

        // GET: ComplaintAndSuggestionController/Details/5
        public ActionResult DetailsForAdmin(DateTime from,DateTime to)
        {
            return View(complaintAndSuggestionService.GetAllForAdmin(from,to));
        }
        // GET: ComplaintAndSuggestionController/Details/5
        [Authorize(Roles ="User")]
        public ActionResult DetailsForUser()
        {
            string UserID = userManager.GetUserId(User);
            return View(complaintAndSuggestionService.GetAllForUser(UserID));
        }
        [Authorize(Roles ="User")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST: ComplaintAndSuggestionController/Create
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Create(ComplaintAndSuggestionVM complaintAndSuggestionVM)
        {
            try
            {
                complaintAndSuggestionVM.userid =userManager.GetUserId(User);
                complaintAndSuggestionVM.date =DateTime.Now;
                complaintAndSuggestionService.Insert(complaintAndSuggestionVM);
                return RedirectToAction("Index","Home");
            }
            catch
            {
                return View();
            }
        }  
        // GET: ComplaintAndSuggestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(complaintAndSuggestionService.GetByID(id));
        }

        // POST: ComplaintAndSuggestionController/Delete/5
        public ActionResult Delete(ComplaintAndSuggestionVM complaintAndSuggestionVM)
        {
            try
            {
                complaintAndSuggestionService.Delete(complaintAndSuggestionVM.id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
