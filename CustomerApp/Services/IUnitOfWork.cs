namespace CustomerApp.Services
{
    public interface IUnitOfWork
    {
        ICustomerService CustomerService { get; }
    }
}
