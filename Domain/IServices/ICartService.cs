using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface ICartService
    {
        IEnumerable<CartVM> GetAll();
        IEnumerable<CartVM> GetAllByUserID(string id);
        CartVM GetByID(int id);
        CartVM GetProductByIDAsNotracking(int id);
        CartVM Insert(CartVM entity);
        CartVM Update(CartVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
