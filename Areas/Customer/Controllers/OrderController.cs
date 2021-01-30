﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Shopping_Store.Data;
using Online_Shopping_Store.Models;
using Online_Shopping_Store.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shopping_Store.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _db = null;
        
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET CheckOut action Method
        public IActionResult CheckOut()
        {
            return View();
        }
        // POST CheckOut action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> CheckOut(Order anOrder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.ProductId = product.Id;
                    //anOrder.OrderDetails = new List<OrderDetails>(); not a good practice do your model
                    anOrder.OrderDetails.Add(orderDetails);
                }
            }
            anOrder.OrderNo = GetOrderNo();
            _db.Orders.Add(anOrder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());

            return View();
        }

        public string GetOrderNo()
        {
            int rowCount = _db.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }
    }
}
