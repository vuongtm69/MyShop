﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IPageRepository
    { }
   public class PageRepository: RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
