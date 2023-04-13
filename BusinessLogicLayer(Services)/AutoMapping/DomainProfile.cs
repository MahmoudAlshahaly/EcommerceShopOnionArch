using AutoMapper;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_Services_.AutoMapping
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<Brand, BrandVM>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<Review, ReviewVM>().ReverseMap();
            CreateMap<ProductImage, ProductImageVM>().ReverseMap();
            CreateMap<Cart, CartVM>().ReverseMap();
            CreateMap<Order, OrderVM>().ReverseMap();
            CreateMap<OrderDetails, OrderDetailsVM>().ReverseMap();
            CreateMap<FavoriteProduct, FavoriteProductVM>().ReverseMap();
            CreateMap<ComplaintAndSuggestion, ComplaintAndSuggestionVM>().ReverseMap();
            CreateMap<ApplicationUser, RegisterVM>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
               .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
               .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
               .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
               .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
               .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.PasswordHash))
               .ReverseMap();
        }
    }
}
