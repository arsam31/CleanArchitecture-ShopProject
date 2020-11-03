using Ecommerce.Application.Interfaces;
using Ecommerce.Application.ViewModels;
using Ecommerce.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services
{
    public class ShopOwnerService : IShopOwner
    {
        public IShopOwnerRepository _shopOwnerRepository;
        public ShopOwnerService(IShopOwnerRepository shopOwnerRepository)
        {
            _shopOwnerRepository = shopOwnerRepository;
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
