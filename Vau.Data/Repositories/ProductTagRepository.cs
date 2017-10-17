using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    { }
   public class ProductTagRepository: RepositoryBase<ProductTag>
    {
        public ProductTagRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
