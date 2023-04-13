using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer_WebUi_.Controllers
{
    [Authorize(Roles ="Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly UserManager<ApplicationUser> userManager;

        public OrderController(IOrderService _orderService, UserManager<ApplicationUser> _userManager)
        {
            orderService = _orderService;
            userManager = _userManager;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            return View(orderService.GetAll());
        }
        public ActionResult GetAllBetweenDates(DateTime from,DateTime to)
        {
            return View(orderService.GetAllBetweenDates(from,to));
        }
        [Authorize(Roles="User")]
        public ActionResult GetForUser()
        {
            string userid = userManager.GetUserId(User);
            return View(orderService.GetAllByUserID(userid));
        }
        public ActionResult Delete(int id)
        {
            try
            {
                orderService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
