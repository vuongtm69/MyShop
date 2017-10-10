﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface ISupportOnlineRepository
    { }
   public class SupportOnlineRepository: RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
