using CustomerApp.Models;
using CustomerApp.Services;
using System.Net.Http;

namespace CustomerApp.ServiceImp
{
    public class CustomerServicecs : ICustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerServicecs(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task AddCustomersync(Customer customerPost) => await _httpClient.PostAsJsonAsync("api/customers", customerPost);

        public async Task DeleteCustomerAsync(int id) => await _httpClient.DeleteAsync($"api/customers/{id}");

        public async Task<Customer> GetCustomerAsync(int id) => await _httpClient.GetFromJsonAsync<Customer>($"api/customers/{id}");

        public async Task<List<Customer>> GetCustomersAsync() => await _httpClient.GetFromJsonAsync<List<Customer>>($"api/customers");

        public async Task UpdateCustomerAsync(Customer customer) => await _httpClient.PutAsJsonAsync($"api/customers/{customer.CustomerID}", customer);
    }
}
