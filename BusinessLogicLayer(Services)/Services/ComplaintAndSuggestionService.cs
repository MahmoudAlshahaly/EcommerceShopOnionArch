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
    public class ComplaintAndSuggestionService : IComplaintAndSuggestionService
    {
        private readonly IGenericRepository<ComplaintAndSuggestion> complaintAndSuggestionService;
        private readonly IMapper mapper;
        public ComplaintAndSuggestionService(IGenericRepository<ComplaintAndSuggestion> _complaintAndSuggestionService, IMapper _mapper)
        {
            complaintAndSuggestionService = _complaintAndSuggestionService;
            mapper = _mapper;
        }
        public IEnumerable<ComplaintAndSuggestionVM> GetAll()
        {
            var ListModel = complaintAndSuggestionService.GetAll().AsQueryable();
            var ListViewModel = mapper.Map<List<ComplaintAndSuggestionVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }
        public IEnumerable<ComplaintAndSuggestionVM> GetAllForAdmin(DateTime from, DateTime to)
        {
            var ListModel = complaintAndSuggestionService.GetAll().Where(a=>a.date >= from && a.date <= to).AsQueryable();
            var ListViewModel = mapper.Map<List<ComplaintAndSuggestionVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }
        public IEnumerable<ComplaintAndSuggestionVM> GetAllForUser(string UserID)
        {
            var ListModel = complaintAndSuggestionService.GetAll().Where(u=>u.userid==UserID).AsQueryable();
            var ListViewModel = mapper.Map<List<ComplaintAndSuggestionVM>>(ListModel.ToList());
            return ListViewModel.AsQueryable();
        }

        public ComplaintAndSuggestionVM GetByID(int id)
        {
            var model = complaintAndSuggestionService.GetAll().FirstOrDefault(a => a.id == id);
            var viewModel = mapper.Map<ComplaintAndSuggestion, ComplaintAndSuggestionVM>(model);
            return viewModel;
        }
        public ComplaintAndSuggestionVM Insert(ComplaintAndSuggestionVM entity)
        {
            var model = mapper.Map<ComplaintAndSuggestionVM, ComplaintAndSuggestion>(entity);
            complaintAndSuggestionService.Insert(model);
            return entity;
        }
        public ComplaintAndSuggestionVM Update(ComplaintAndSuggestionVM entity)
        {
            var model = mapper.Map<ComplaintAndSuggestionVM, ComplaintAndSuggestion>(entity);
            complaintAndSuggestionService.Update(model);
            return entity;
        }
        public void Delete(int id)
        {
            complaintAndSuggestionService.Delete(id);
        }
        public void DeleteAll()
        {
            complaintAndSuggestionService.DeleteAll();
        }
    }
}
