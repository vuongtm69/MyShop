using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IPostTagRepository
    { }
   public class PostTagRepository: RepositoryBase<PostTag>
    {
        public PostTagRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
