using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Infrastrcuture.AppDBContext;



namespace Infrastrcuture.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository (AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
           return  await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
          
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
