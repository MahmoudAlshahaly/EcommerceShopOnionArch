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
    public class ReviewService : IReviewService
    {
        private readonly IGenericRepository<Review> reviewService;
        private readonly IMapper mapper;
        public ReviewService(IGenericRepository<Review> _reviewService, IMapper _mapper)
        {
            reviewService = _reviewService;
            mapper = _mapper;
        }
        public void Delete(int id)
        {
            reviewService.Delete(id);
        }
        public void DeleteAll()
        {
            reviewService.DeleteAll();
        }
        public IEnumerable<ReviewVM> GetAll()
        {
            var ListModel = reviewService.GetAll().AsQueryable();
            var ListViewModel = mapper.Map<List<ReviewVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }
        public IEnumerable<ReviewVM> GetAllByProductID(int id)
        {
            var ListModel = reviewService.GetAll().Where(p => p.productid==id).AsQueryable();
            var ListViewModel = mapper.Map<List<ReviewVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }

        public ReviewVM GetByID(int id)
        {
            var model = reviewService.GetAll().FirstOrDefault(a => a.id == id);
            var viewModel = mapper.Map<Review, ReviewVM>(model);
            return viewModel;
        }
        public ReviewVM Insert(ReviewVM entity)
        {
            var model = mapper.Map<ReviewVM, Review>(entity);
            reviewService.Insert(model);
            return entity;
        }
        public ReviewVM Update(ReviewVM entity)
        {
            var model = mapper.Map<ReviewVM, Review>(entity);
            reviewService.Update(model);
            return entity;
        }
    }

}
