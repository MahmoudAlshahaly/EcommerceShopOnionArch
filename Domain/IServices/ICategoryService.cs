using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface ICategoryService
    {
        IEnumerable<CategoryVM> GetAll();
        CategoryVM GetByID(int id);
        CategoryVM GetByIDNoTracking(int id);
        CategoryVM Insert(CategoryVM entity);
        CategoryVM Update(CategoryVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
