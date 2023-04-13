using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.IServices
{
    public interface IFavoriteProductService
    {
        FavoriteProductVM GetByID(int id);
        IEnumerable<FavoriteProductVM> GetAllForUser(string UserID);
        FavoriteProductVM GetIFAddToFavoriteProduct(int Productid,string UserID);
        FavoriteProductVM Insert(FavoriteProductVM entity);
        void Delete(int id);
        void DeleteAll();
    }
}
