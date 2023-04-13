using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface IProductService
    {
        IEnumerable<ProductVM> GetAll();
        ProductVM GetByID(int id);
        ProductVM GetByIDNoTracking(int id);
        IEnumerable<ProductVM> GetAll(string name);
        ProductVM Insert(ProductVM entity);
        ProductVM Update(ProductVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
