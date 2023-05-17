 
using OpenERX.Commons.Params;
using OpenERX.Commons.Results;
using OpenERX.Commons.Types.Results;

namespace OpenERX.Core.Customers
{
    public interface ICustomerService : IResultService
    {
        Task<CustomerResult> CreateAsync(CustomerParams createParams);
        Task<CustomerResult> UpdateAsync(Guid id, CustomerParams updateParams);
        Task<CustomerResult> UpdateStatusAsync(Guid id, UpdateStatusParams3 updateParams);
        Task<CountResult> DeleteAsync(IdParams deleteParams); 
        Task<CustomerResult> GetAsync(Guid id); 
    }
}
