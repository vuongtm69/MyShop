namespace Vau.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}