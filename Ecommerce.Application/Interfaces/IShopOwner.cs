using Ecommerce.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Interfaces
{
    public interface IShopOwner
    {
        ShopOwnerViewModel GetShopOwner();
    }
}
