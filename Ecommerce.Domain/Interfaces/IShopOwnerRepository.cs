using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces
{
    public interface IShopOwnerRepository
    {
        IEnumerable<ShopOwner> GetShopOwners();
    }
}
