 
namespace OpenERX.Core.Customers
{
    public interface ICustomerRepository
    {
        Task<Customer> InsertAsync(Customer customer);
        Task InsertManyAsync(IList<Customer> customers);
        Task<long> UpdateAsync(Customer customer);
        Task<long> DeleteAsync(Guid id);
        Task<Customer> GetAsync(Guid id);
        Task<Customer> GetAsync(int accountCode, Guid id);
    }
}
