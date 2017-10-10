﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface ISlideRepository
    { }
   public class SlideRepository: RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
