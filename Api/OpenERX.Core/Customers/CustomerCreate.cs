
using OpenERX.Commons.Credentials;
using OpenERX.Commons.Results;

namespace OpenERX.Core.Customers
{
    public partial class Customer
    {
        public static async Task<Customer> CreateAsync(
        CustomerParams createParams,
        Credential credential,
        IResultService resultService)
        {
            if (createParams is null)
                resultService.AddMessage(new ResultMessage(ResultMessageTypes.Error, "Parâmentros Inválidos"));
 
            if (string.IsNullOrWhiteSpace(createParams?.Name))
                resultService.AddMessage(new ResultMessage(ResultMessageTypes.Error, "Nome Inválido"));
  
            if (string.IsNullOrWhiteSpace(createParams?.Identity))
                resultService.AddMessage(new ResultMessage(ResultMessageTypes.Error, "CPF/CNPJ Inválido"));
 
            if (resultService.HasErrors())
                return null;
 
            var model = new Customer();
 
            await model.SetParamsAsync(
            createParams,
            credential, 
            resultService);

            //model.Code = await settingService.GetNextCodeAsync(credential, Feature.Customer);

            //model.RecordCreate(credential);

            return model;
        }
    }
}
