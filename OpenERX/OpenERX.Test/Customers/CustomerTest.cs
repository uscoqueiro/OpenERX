using OpenERX.Core.Customers;

namespace OpenERX.Test.Customers
{
    [TestClass]
    public class CustomerTest: Dependency
    {
        [TestMethod]
        public async void CreateAsync()
        {
            var customer = new CustomerParams
            {
                
            };
 
            var result = await customerService.CreateAsync(customer);
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