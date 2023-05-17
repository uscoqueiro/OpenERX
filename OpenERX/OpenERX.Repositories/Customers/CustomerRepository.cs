// COMPANY: Ajinsoft
// AUTHOR: Uilan Coqueiro
// DATE: 2023-05-17


using OpenERX.Core.Customers;
using OpenERX.Repositories.Shared.Sql;

namespace OpenERX.Repositories.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SqlConnectionProvider _connectionProvider;

        public CustomerRepository(SqlConnectionProvider connectionProvider)
        {
 
        }
 
        public Task<Customer> InsertAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task InsertManyAsync(IList<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public Task<long> UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<long> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(int accountCode, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
