using BusinessLogicLayer_Services_.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationLayer_WebUi_.Models;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer_WebUi_.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ICartService cartService;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IOrderService orderService;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(
            ICartService _cartService,
            IProductService _productService,
            ICategoryService _categoryService,
            IOrderService _orderService,
            UserManager<ApplicationUser> _userManager)
        {
            cartService = _cartService;
            productService = _productService;
            categoryService = _categoryService;
            orderService = _orderService;
            userManager = _userManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(categoryService.GetAll());
        }
        public IActionResult Cart()
        {
            string userid = userManager.GetUserId(User);
            return View(cartService.GetAllByUserID("1"));
        }
        [HttpPost]
        public IActionResult CheckOutOrder(decimal total,decimal totalAfter)
        {
            string userid= userManager.GetUserId(User);
            OrderVM ordervm = new OrderVM();
            ordervm.isonlinepaid = true;
            ordervm.total = total;
            ordervm.Userid = userid;
            ordervm.totalaftertax = totalAfter;
            ordervm.taxvalue = totalAfter - total;
            ordervm.date = DateTime.Now;
            var cartVM = cartService.GetAllByUserID(userid);
            foreach (var item in cartVM)
            {
                
                ordervm.OrderDetails.Add(
                    new OrderDetailsVM
                    {
                        quantity = item.quantity,
                        Productid = item.Productid,
                        saleprice = item.Product.saleprice,
                        totalsale = (item.quantity * item.Product.saleprice)

                    });
                item.Product.quantityavailable -= item.quantity;
                productService.Update(item.Product);

                ordervm.total += (item.quantity * item.Product.saleprice);
                cartService.Delete(item.id);
            }

            orderService.Insert(ordervm);
            //User.Identity.Name
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult AddToCart(int id)
        {
            if (AddProductToCart(id)==false)
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
        public bool AddProductToCart(int id)
        {
            CartVM cartVM = new CartVM();
            cartVM.Productid = id;
            cartVM.quantity = 1;
            cartVM.userid = userManager.GetUserId(User);
            var ProductInCartExistOrNot = cartService.GetProductByIDAsNotracking(cartVM.Productid);
            if (ProductInCartExistOrNot == null)
            {
                cartService.Insert(cartVM);
            }
            else
            {
                ProductInCartExistOrNot.quantity += 1;
                //if (ProductInCartExistOrNot.quantity > ProductInCartExistOrNot.Product.quantityavailable)
                //{
                //    return false;
                //}
                cartService.Update(ProductInCartExistOrNot);
            }
            return true;
        }
        public IActionResult PLusToCart(int id)
        {
            if (AddProductToCart(id)==false)
            {
                return View();
            }

            return RedirectToAction(nameof(Cart));
        }
        public IActionResult MinusFromCart(int id)
        {
            var ProductFromCart = cartService.GetProductByIDAsNotracking(id);
            if (ProductFromCart.quantity == 1)
            {
                DeleteProductFromCart(id);
            }
            else
            {
                ProductFromCart.quantity -= 1;
                cartService.Update(ProductFromCart);
            }
            return RedirectToAction(nameof(Cart));
        }
        public IActionResult DeleteProductFromCart(int id)
        {
            //User.Identity.Name
            cartService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
