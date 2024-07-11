using CustomerApp.Models;

namespace CustomerApp.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomersAsync();

        Task<Customer> GetCustomerAsync(int id);

        Task AddCustomersync(Customer customerPost);

        Task UpdateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(int id);
    }
}
