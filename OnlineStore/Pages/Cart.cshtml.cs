﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStore.Infrastructure;
using OnlineStore.Models;


namespace OnlineStore.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;

        public CartModel(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnURL { get; set; }
        public bool Disabled { get; set; } = false;

        public void OnGet(string returnUrl)
        {
            ReturnURL = returnUrl ?? "/";
            Disabled = (Cart.ComputeTotalValue() == 0) ? true : false;
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(product, 1);
            Disabled = (Cart.ComputeTotalValue() == 0) ? true : false;
            //HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
            
        }

        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Product.ProductID == productId).Product);
            Disabled = (Cart.ComputeTotalValue() == 0) ? true : false;
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
