﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {

    }
   public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
