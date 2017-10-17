using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IMenuFactory: IRepository<Menu>
    {

    }
   public class MenuFactory: RepositoryBase<Menu>, IMenuFactory
    {
        public MenuFactory(IDbFactory dbFactory): base(dbFactory)
        { }
    }
}
