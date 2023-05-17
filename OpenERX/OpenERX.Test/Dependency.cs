using Microsoft.Extensions.DependencyInjection;
using OpenERX.Core.Customers;
using OpenERX.Repositories.Customers;
using OpenERX.Repositories.Shared.Sql;
using OpenERX.Services.Customers;

namespace OpenERX.Test
{
    [TestClass]
    public class Dependency
    {
        public ICustomerService customerService;

        [TestInitialize]
        public void Init()
        {
           var services = new ServiceCollection();
            services.AddTransient<SqlConnectionProvider>(_ => new SqlConnectionProvider("server=.;database=db_xpto;user=xpto;password=123456"));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICustomerService, CustomerService>();

            var provider = services.BuildServiceProvider();
            this.customerService = provider.GetService<ICustomerService>();

        }
    }
}
