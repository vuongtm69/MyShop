using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IOrderRepository
    { }
   public class OrderRepository: RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
