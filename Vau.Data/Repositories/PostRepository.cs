using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IPostRepository
    { }
   public class PostRepository: RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
