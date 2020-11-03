using AutoMapper;
using Ecomerce.Application.ViewModels;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecomerce.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<ShopOwner, ShopOwnerViewModel>();
            CreateMap<ShopOwnerViewModel, ShopOwner>().ReverseMap();
        }
    }
}
