using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface IOrderService
    {
        IEnumerable<OrderVM> GetAll();
        IEnumerable<OrderVM> GetAllBetweenDates(DateTime from,DateTime to);
        IEnumerable<OrderVM> GetAllByUserID(string id);
        OrderVM GetByID(int id);
        OrderVM Insert(OrderVM entity);
        OrderVM Update(OrderVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
