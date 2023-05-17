
using OpenERX.Commons.Credentials;
using OpenERX.Commons.Functions;
using OpenERX.Commons.Results;
using OpenERX.Commons.Types.Addresses;
using OpenERX.Commons.Types.Fields;
using OpenERX.Commons.Types.Phones;
using OpenERX.Commons.Types.Sites;
using OpenERX.Core.Shared;

namespace OpenERX.Core.Customers
{
    public partial class Customer
    {
        public static async Task<Customer> CreateAsync(
        CustomerParams createParams,
        Credential credential,
        IResultService resultService)
        {
            var model = new Customer();

            //model.SetFullAssociation(credential);


            //model.TypeCode = createParams.TypeCode ?? 0;
            //model.TypeName = createParams.TypeName;
            //model.Name = createParams.Name;
            //model.Nickname = createParams.Nickname;
            //model.Display = createParams.Display;
            //model.BirthDate = DateFunctions.GetDateTimeNullable(createParams.BirthDate);
            //model.PersonTypeCode = createParams.PersonTypeCode ?? 0;
            //model.PersonTypeName = createParams.PersonTypeName;
            //model.Identity = createParams.Identity;
            //model.ExternalCode = createParams.ExternalCode;
            //model.Addresses = Address.CreateEntityList(createParams.Addresses);
            //model.Phones = Phone.CreateEntityList(createParams.Phones);
            //model.Emails = EmailAddress.CreateEntityList(createParams.Emails);
            //model.Sites = Site.CreateEntityList(createParams.Sites);
            //model.Fields = DataField.CreateEntityList(createParams.Fields, resultService);
            //model.StatusCode = createParams.StatusCode ?? 0;
            //model.StatusName = createParams.StatusName;
            //model.StatusDate = DateFunctions.GetDateTimeNullable(createParams.StatusDate);
            //model.StatusColor = createParams.StatusColor;
            //model.StatusNote = createParams.StatusNote;
            //model.OriginId = GuidFunctions.GetGuid(createParams.OriginId);
            //model.OriginCode = createParams.OriginCode ?? 0;
            //model.OriginName = createParams.OriginName;
            //model.Note = createParams.Note;
            //model.StoreId = GuidFunctions.GetGuid(createParams.StoreId);
            //model.StoreCode = createParams.StoreCode ?? 0;
            //model.StoreName = createParams.StoreName;
            //model.BrokerId = GuidFunctions.GetGuid(createParams.BrokerId);
            //model.BrokerCode = createParams.BrokerCode ?? 0;
            //model.BrokerName = createParams.BrokerName;

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
