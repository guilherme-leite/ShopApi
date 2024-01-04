namespace ShopApi.Data
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
