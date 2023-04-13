using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface IReviewService
    {
        IEnumerable<ReviewVM> GetAll();
        IEnumerable<ReviewVM> GetAllByProductID(int id);
        ReviewVM GetByID(int id);
        ReviewVM Insert(ReviewVM entity);
        ReviewVM Update(ReviewVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
