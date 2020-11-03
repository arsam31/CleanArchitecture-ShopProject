using AutoMapper;
using Ecomerce.Application.Interfaces;
using Ecomerce.Application.ViewModels;
using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.Application.Services
{
    public class ShopOwnerService : IShopOwner
    {
        public IShopOwnerRepository _shopOwnerRepository;
        private readonly IMapper _mapper;
        public ShopOwnerService(IShopOwnerRepository shopOwnerRepository, IMapper mapper)
        {
            _shopOwnerRepository = shopOwnerRepository;
            _mapper = mapper;
        }
        public ShopOwnerViewModel GetShopOwner()
        {
            return new ShopOwnerViewModel()
            {
                ShopOwners = _shopOwnerRepository.GetShopOwners()
            };
        }

    }
}
