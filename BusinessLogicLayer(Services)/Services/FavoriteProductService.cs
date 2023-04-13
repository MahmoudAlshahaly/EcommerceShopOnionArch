using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SharedLayer.Domain.IRepositories;
using SharedLayer.Domain.IServices;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_Services_.Services
{
    public class FavoriteProductService : IFavoriteProductService
    {
        private readonly IGenericRepository<FavoriteProduct> favoriteProductService;
        private readonly IMapper mapper;
        public FavoriteProductService(IGenericRepository<FavoriteProduct> _favoriteProductService, IMapper _mapper)
        {
            favoriteProductService = _favoriteProductService;
            mapper = _mapper;
        }
        public void Delete(int id)
        {
            favoriteProductService.Delete(id);
        }
        public void DeleteAll()
        {
            favoriteProductService.DeleteAll();
        }
        public IEnumerable<FavoriteProductVM> GetAll()
        {
            var ListModel = favoriteProductService.GetAll().AsQueryable();
            var ListViewModel = mapper.Map<List<FavoriteProductVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }
        public IEnumerable<FavoriteProductVM> GetAllForUser(string UserID)
        {
            var ListModel = favoriteProductService.GetAll().Include(p=>p.Product).Where(u=>u.userid==UserID).AsQueryable();
            var ListViewModel = mapper.Map<List<FavoriteProductVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }

        public FavoriteProductVM GetByID(int id)
        {
            var model = favoriteProductService.GetAll().FirstOrDefault(a => a.id == id);
            var viewModel = mapper.Map<FavoriteProduct, FavoriteProductVM>(model);
            return viewModel;
        }

        public FavoriteProductVM GetIFAddToFavoriteProduct(int Productid,string UserID)
        {
            var model = favoriteProductService.GetAll().FirstOrDefault(a => a.productid == Productid && a.userid==UserID);
            var viewModel = mapper.Map<FavoriteProduct, FavoriteProductVM>(model);
            return viewModel;
        }

        public FavoriteProductVM Insert(FavoriteProductVM entity)
        {
            var model = mapper.Map<FavoriteProductVM, FavoriteProduct>(entity);
            favoriteProductService.Insert(model);
            return entity;
        }
        public FavoriteProductVM Update(FavoriteProductVM entity)
        {
            var model = mapper.Map<FavoriteProductVM, FavoriteProduct>(entity);
            favoriteProductService.Update(model);
            return entity;
        }
    }

}
