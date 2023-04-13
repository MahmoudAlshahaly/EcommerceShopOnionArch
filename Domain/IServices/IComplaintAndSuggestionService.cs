using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface IComplaintAndSuggestionService
    {
        ComplaintAndSuggestionVM GetByID(int id);
        IEnumerable<ComplaintAndSuggestionVM> GetAll();
        IEnumerable<ComplaintAndSuggestionVM> GetAllForUser(string UserID);
        IEnumerable<ComplaintAndSuggestionVM> GetAllForAdmin(DateTime from,DateTime to);
        ComplaintAndSuggestionVM Insert(ComplaintAndSuggestionVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
