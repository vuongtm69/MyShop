namespace Vau.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private VauShopDbContext dbContext;

        public VauShopDbContext Init()
        {
            return dbContext ?? (dbContext = new VauShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}