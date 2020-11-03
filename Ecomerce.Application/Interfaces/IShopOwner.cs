using Ecomerce.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.Application.Interfaces
{
    public interface IShopOwner
    {
        ShopOwnerViewModel GetShopOwner();
    }
}
