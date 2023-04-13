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
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> productService;
        private readonly IMapper mapper;
        public ProductService(IGenericRepository<Product> _productService, IMapper _mapper)
        {
            productService = _productService;
            mapper = _mapper;
        }
        public void Delete(int id)
        {
            productService.Delete(id);
        }
        public void DeleteAll()
        {
            productService.DeleteAll();
        }
        public IEnumerable<ProductVM> GetAll()
        {
            var ListModel = productService.GetAll().Include(b=>b.Brand).Include(c=>c.Category).AsQueryable();
            var ListViewModel = mapper.Map<List<ProductVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }
        public IEnumerable<ProductVM> GetAll(string name)
        {
            var ListModel = productService.GetAll().Where(p=>p.name.Contains(name)).AsQueryable();
            var ListViewModel = mapper.Map<List<ProductVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }
        public ProductVM GetByID(int id)
        {
            var model = productService.GetAll()
                .Include(r=>r.Reviews)
                .Include(c=>c.Category)
                .Include(b=>b.Brand)
                .Include(i=>i.ProductImage).FirstOrDefault(a => a.id == id);


                //.Select(p =>
                //new Product
                //{
                //    id = p.id,
                //    name = p.name,
                //    imageurl = p.imageurl,
                //    description = p.description,
                //    quantityavailable = p.quantityavailable,
                //    saleprice = p.saleprice,
                //    Brand = p.Brand,
                //    Category = p.Category,
                //    ProductImage = p.ProductImage.ToList(),
                //    Reviews = p.Reviews.ToList()
                //}).FirstOrDefault(a => a.id == id);
                
                           
            var viewModel = mapper.Map<Product, ProductVM>(model);
            return viewModel;
        }
        public ProductVM GetByIDNoTracking(int id)
        {
            //var model = productService.GetAll().Where(a => a.id == id).AsNoTracking()
            //    .Include(r => r.Reviews)
            //    .Include(c => c.Category)
            //    .Include(b => b.Brand)
            //    .Include(i => i.ProductImage).FirstOrDefault();


           var model = productService.GetAll().Where(a => a.id == id).AsNoTracking().Select(p =>
           new Product
           {
               id = p.id,
               name = p.name,
               imageurl = p.imageurl,
               description = p.description,
               quantityavailable = p.quantityavailable,
               saleprice = p.saleprice,
               Brand = p.Brand,
               Category = p.Category,
               ProductImage = p.ProductImage.ToList(),
               Reviews = p.Reviews.ToList()
           }).FirstOrDefault();


            var viewModel = mapper.Map<Product, ProductVM>(model);
            return viewModel;
        }
        public ProductVM Insert(ProductVM entity)
        {
            var model = mapper.Map<ProductVM, Product>(entity);
            productService.Insert(model);
            return entity;
        }
        public ProductVM Update(ProductVM entity)
        {
            var model = mapper.Map<ProductVM, Product>(entity);
            productService.Update(model);
            return entity;
        }
    }

}
