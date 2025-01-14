﻿using Domain.Entities;

namespace Repository.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetAllProductsWithCategories();

    }
}
