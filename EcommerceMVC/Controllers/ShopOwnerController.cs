using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecomerce.Application.Interfaces;
using Ecomerce.Application.ViewModels;
using Ecommerce.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class ShopOwnerController : Controller
    {
        private IShopOwner _shopOwner;
        public ShopOwnerController(IShopOwner shopOwner)
        {
            _shopOwner = shopOwner;
        }
        public IActionResult Index()
        {
            ShopOwnerViewModel model = _shopOwner.GetShopOwner();
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateShop(ShopOwnerViewModel model)
        {
            _shopOwner.AddShopOwner(model);
            return RedirectToAction("Index");
        }
    }
}

