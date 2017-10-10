using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Model.Models;

namespace Vau.Data.Repositories
{
    public interface IMenuGroupRepository
    {

    }
  public class MenuGroupRepository: RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory): base(dbFactory)
        { }
    }
}
