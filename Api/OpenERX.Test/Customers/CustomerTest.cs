using System.Text;
using OpenERX.Core.Customers;

namespace OpenERX.Test.Customers
{
    [TestClass]
    public class CustomerTest : Dependency
    {
        [TestMethod]
        public async Task CustomerCreateAsync()
        {
            var createParams = new CustomerParams
            {
                Name = "João da Silva",
                Identity = "98765432178",
                TypeCode = 1
            };
 
            var result = await customerService.CreateAsync(createParams);

            if (customerService.HasErrors())
            {
                var sb = new StringBuilder();
                foreach (var error in customerService.Errors)
                {
                    sb.AppendLine(error.Text);
                }
 
                throw new Exception(sb.ToString());
            }
        }
 

        [TestMethod]
        public async void Update()
        {
            var customer = new CustomerParams
            {

            };

            var result = await customerService.UpdateAsync(new Guid(), customer);
        }


        [TestMethod]
        public async void Get()
        {
            var result = await customerService.GetAsync(new Guid());
        }


        [TestMethod]
        public async void List()
        {

        }

    }
}