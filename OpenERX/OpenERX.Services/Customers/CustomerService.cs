 
using OpenERX.Commons.Credentials;
using OpenERX.Commons.Params;
using OpenERX.Commons.Results;
using OpenERX.Commons.Types.Results;
using OpenERX.Core.Customers;
using OpenERX.Core.Shared;

namespace OpenERX.Services.Customers
{
    public class CustomerService : ResultService, ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(
            ICustomerRepository customerRepository
        )
        {
            this.customerRepository = customerRepository;

        }

        public async Task<CustomerResult> CreateAsync(CustomerParams createParams)
        {
            var credential = new Credential();

            try
            {
                var model = await Customer.CreateAsync(
                    createParams,
                    credential,
                    this);

                if (this.HasErrors())
                    return null;

                await this.customerRepository.InsertAsync(model);

                return new CustomerResult(model);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<CustomerResult> UpdateAsync(Guid id, CustomerParams updateParams)
        {
            var credential = new Credential();

            try
            {

                var model = await this.customerRepository.GetAsync(credential.AccountCode, id);

                await model.UpdateAsync(
                    updateParams,
                    credential,
                    this);

                if (this.HasErrors())
                    return null;

                await this.customerRepository.UpdateAsync(model);

                return new CustomerResult(model);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<CustomerResult> UpdateStatusAsync(Guid id, UpdateStatusParams3 statusParams)
        {

            var credential = new Credential();

            try
            {


                var model = await this.customerRepository.GetAsync(credential.AccountCode, id);



                model.UpdateStatus(statusParams, credential, this);

                if (this.HasErrors())
                    return null;

                await this.customerRepository.UpdateAsync(model);

                return new CustomerResult(model);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<CountResult> DeleteAsync(IdParams deleteParams)
        {
            var credential = new Credential();

            try
            {

                if (deleteParams?.Ids == null)
                    return null;

                var result = new CountResult
                {
                    Count = deleteParams.Ids.Count
                };

                foreach (var id in deleteParams.Ids)
                {
                    var model = await this.customerRepository.GetAsync(credential.AccountCode, id);


                    await this.customerRepository.UpdateAsync(model);


                    result.Success++;
                }

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
 
        public async Task<CustomerResult> GetAsync(Guid id)
        {
            var credential = new Credential();

            try
            {


                var model = await this.customerRepository.GetAsync(credential.AccountCode, id);


                return new CustomerResult(model);
            }
            catch (Exception e)
            {

                return null;
            }
        }

    }
}
