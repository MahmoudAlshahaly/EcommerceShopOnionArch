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
    public class CategoryService:ICategoryService
    {

        private readonly IGenericRepository<Category> categoryService;
        private readonly IMapper mapper;
        public CategoryService(IGenericRepository<Category> _categoryService, IMapper _mapper)
        {
            categoryService = _categoryService;
            mapper = _mapper;
        }
        public void Delete(int id)
        {
            categoryService.Delete(id);
        }
        public void DeleteAll()
        {
            categoryService.DeleteAll();
        }
        public IEnumerable<CategoryVM> GetAll()
        {
            //test case about tracking 

            // if i use select ()  in this case not tracking any time 

            //var data = categoryService.GetAll().FirstOrDefault();
            //data.name = "ahmed";
            //var trackers = db.ChangeTracker.Entries();


            //foreach (var item in trackers)
            //{
            //    var a = item.Entity + "   " + item.State;
            //}



            //explicit loading 
            //var data = categoryService.GetAll().FirstOrDefault();
            //using reference  when select navigation property
            // db.Entry(data).Reference(a => a.authors).Load();
            //using collection when select collection
            // db.Entry(data).Collection(a => a.Products).Load();

            //how can i make query in this collection (related data)
            //db.Entry(data).Collection(a => a.Products).Query().Where(a=>a.price==10).ToList();

            //use lazy loading by proxies library
            //var data = categoryService.GetAll().FirstOrDefault();
            // var a = data.Products.First().name;

            var ListModel = categoryService.GetAll().Include(cat => cat.Products).AsQueryable();
            var ListViewModel = mapper.Map<List<Category> , List<CategoryVM>>(ListModel.ToList());
            return ListViewModel;
        }
        public CategoryVM GetByID(int id)
        {
            var model = categoryService.GetAll().Include(p=>p.Products).FirstOrDefault(a => a.id == id);
            var viewModel = mapper.Map<Category, CategoryVM>(model);
            return viewModel;
        }
        public CategoryVM GetByIDNoTracking(int id)
        {
            var model = categoryService.GetAll().Where(a => a.id == id).AsNoTracking().FirstOrDefault();
            var viewModel = mapper.Map<Category, CategoryVM>(model);
            return viewModel;
        }
        public CategoryVM Insert(CategoryVM entity)
        {
            var model = mapper.Map<CategoryVM, Category>(entity);
            categoryService.Insert(model);
            return entity;
        }
        public CategoryVM Update(CategoryVM entity)
        {
            var model = mapper.Map<CategoryVM, Category>(entity);
            categoryService.Update(model);
            return entity;
        }
    }
}
