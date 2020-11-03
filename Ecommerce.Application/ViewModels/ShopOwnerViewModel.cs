using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.ViewModels
{
    public class ShopOwnerViewModel
    {
        public IEnumerable<ShopOwner> ShopOwners { get; set; }
    }
}
