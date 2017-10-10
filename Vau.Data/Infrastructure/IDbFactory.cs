using System;

namespace Vau.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        VauShopDbContext Init();
    }  
}