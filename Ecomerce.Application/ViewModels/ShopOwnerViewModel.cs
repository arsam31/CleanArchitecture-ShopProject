using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecomerce.Application.ViewModels
{
    public class ShopOwnerViewModel
    {
        public string OwnerName { get; set; }
        public string ShopName { get; set; }
        public IEnumerable<ShopOwner> ShopOwners { get; set; }
    }
}
