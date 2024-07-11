using CustomerApp.Services;
using System.Net.Http;

namespace CustomerApp.ServiceImp
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HttpClient _httpClient;

        public UnitOfWork(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public ICustomerService CustomerService => new CustomerServicecs(_httpClient);
    }
}
