﻿using InvoiceMenager.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;


namespace InvoiceMenager.Models.Repository
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Products.ToList();
            }
        }

        internal Product GetProduct(int productId)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Products.Single(x=> x.Id ==productId);
            }
        }
    }
}