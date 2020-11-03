using AutoMapper;
using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Models;
using EcommerceMVC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class ShopOwnerRepository : IShopOwnerRepository
    {
        public ApplicationDbContext _context;
        
        public ShopOwnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ShopOwner> GetShopOwners()
        {
            return _context.ShopOwners;
        }
    }
}
