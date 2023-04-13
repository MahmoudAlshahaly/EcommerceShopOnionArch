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
    public class OrderService:IOrderService
    {

        private readonly IGenericRepository<Order> orderService;
        private readonly IMapper mapper;

        public OrderService(IGenericRepository<Order> _orderService, IMapper _mapper)
        {
            orderService = _orderService;
            mapper = _mapper;
        }
        public void Delete(int id)
        {
            orderService.Delete(id);
        }
        public void DeleteAll()
        {
            orderService.DeleteAll();
        }

        public IEnumerable<OrderVM> GetAll()
        {
            var ListModel = orderService.GetAll().Include(cat => cat.OrderDetails).ThenInclude(p=>p.Product).AsQueryable();
            var ListViewModel = mapper.Map< List<Order> ,List<OrderVM> >(ListModel.ToList());
            return ListViewModel;
        }
        public IEnumerable<OrderVM> GetAllBetweenDates(DateTime from, DateTime to)
        {
            var ListModel = orderService.GetAll().Where(a => a.date >= from && a.date <= to).Include(cat => cat.OrderDetails).ThenInclude(p => p.Product).AsQueryable();
            var ListViewModel = mapper.Map<List<Order>, List<OrderVM>>(ListModel.ToList());
            return ListViewModel;
        }
        public IEnumerable<OrderVM> GetAllByUserID(string id)
        {
            var ListModel = orderService.GetAll().Include(cat => cat.OrderDetails).ThenInclude(p => p.Product).Where(c=>c.Userid== id).AsQueryable();
            var ListViewModel = mapper.Map<List<Order>, List<OrderVM>>(ListModel.ToList());
            return ListViewModel;
        }

        public OrderVM GetByID(int id)
        {
            var model = orderService.GetAll().Include(cat => cat.OrderDetails).ThenInclude(p => p.Product).FirstOrDefault(a => a.id == id);
            var viewModel = mapper.Map<Order, OrderVM>(model);
            return viewModel;
        }
        public OrderVM Insert(OrderVM entity)
        {
            var model = mapper.Map<OrderVM, Order>(entity);
            orderService.Insert(model);
            return entity;
        }

        public OrderVM Update(OrderVM entity)
        {
            var model = mapper.Map<OrderVM, Order>(entity);
            orderService.Update(model);
            return entity;
        }
    }
}
