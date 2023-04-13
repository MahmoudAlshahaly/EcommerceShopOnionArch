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
using DataAccessLayer.Infrastructure.DataBase;

namespace BusinessLogicLayer_Services_.Services
{
    public class BrandService:IBrandService
    {

        private readonly IGenericRepository<Brand> brandService;
        private readonly IMapper mapper;

        public BrandService(IGenericRepository<Brand> _brandService, IMapper _mapper)
        {
            brandService = _brandService;
            mapper = _mapper;
        }

        public void Delete(int id)
        {
            brandService.Delete(id);
        }

        public void DeleteAll()
        {
            brandService.DeleteAll();
        }

        public IEnumerable<BrandVM> GetAll()
        {
            var ListModel = brandService.GetAll().Include(cat => cat.Products).AsQueryable();
            var ListViewModel = mapper.Map<List<Brand> , List<BrandVM>>(ListModel.ToList());
            return ListViewModel;
        }
        public BrandVM GetByID(int id)
        {
            var model = brandService.GetAll().Include(cat => cat.Products).FirstOrDefault(a => a.id == id);
            var viewModel = mapper.Map<Brand, BrandVM>(model);
            return viewModel;
        }
        public BrandVM Insert(BrandVM entity)
        {
            var model = mapper.Map<BrandVM, Brand>(entity);
            brandService.Insert(model);
            return entity;
        }

        public BrandVM Update(BrandVM entity)
        {
            var model = mapper.Map<BrandVM, Brand>(entity);
            brandService.Update(model);
            return entity;
        }
    }
}
