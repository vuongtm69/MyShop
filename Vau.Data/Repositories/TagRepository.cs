using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface ITagRepository
    { }
   public class TagRepository: RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
