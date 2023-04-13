using AutoMapper;
using SharedLayer.Domain.IRepositories;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BusinessLogicLayer_Services_.Services
{
    public class CartService:ICartService
    {
        private readonly IGenericRepository<Cart> cartService;
        private readonly IMapper mapper;
        public CartService(IGenericRepository<Cart> _cartService, IMapper _mapper)
        {
            cartService = _cartService;
            mapper = _mapper;
        }
        public void Delete(int id)
        {
            cartService.Delete(id);
        }
        public void DeleteAll()
        {
            cartService.DeleteAll();
        }

        public IEnumerable<CartVM> GetAll()
        {
            var ListModel = cartService.GetAll().Include(cat => cat.Product).AsQueryable();
            var ListViewModel = mapper.Map< List<Cart> ,List<CartVM> >(ListModel.ToList());
            return ListViewModel;
        }
        public IEnumerable<CartVM> GetAllByUserID(string id)
        {
            var ListModel = cartService.GetAll().Include(cat => cat.Product).Where(c=>c.userid== id).AsNoTracking().AsQueryable();
            var ListViewModel = mapper.Map<List<Cart>, List<CartVM>>(ListModel.ToList());
            return ListViewModel;
        }

        public CartVM GetByID(int id)
        {
            var model = cartService.GetAll().Include(cat => cat.Product).FirstOrDefault(a => a.id == id);
            var viewModel = mapper.Map<Cart, CartVM>(model);
            return viewModel;
        }
        public CartVM GetProductByIDAsNotracking(int id)
        {
            var model = cartService.GetAll().Include(cat => cat.Product).AsNoTracking().FirstOrDefault(a => a.Productid == id);
            var viewModel = mapper.Map<Cart, CartVM>(model);
            return viewModel;
        }
        public CartVM Insert(CartVM entity)
        {
            var model = mapper.Map<CartVM, Cart>(entity);
            cartService.Insert(model);
            return entity;
        }

        public CartVM Update(CartVM entity)
        {
            var model = mapper.Map<CartVM, Cart>(entity);
            cartService.Update(model);
            return entity;
        }
    }
}
