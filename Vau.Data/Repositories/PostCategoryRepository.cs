using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IPostCategoryRepository
    { }
   public class PostCategoryRepository: RepositoryBase<PostCategory>
    {
        public PostCategoryRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
