﻿using FoodDeliveryShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryShop.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Products);
    }

}
