using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface IBrandService
    {
        IEnumerable<BrandVM> GetAll();
        BrandVM GetByID(int id);
        BrandVM Insert(BrandVM entity);
        BrandVM Update(BrandVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
