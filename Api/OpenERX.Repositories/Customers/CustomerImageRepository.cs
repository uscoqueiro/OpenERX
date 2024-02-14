// COMPANY: Ajinsoft
// AUTHOR: Uilan Coqueiro
// DATE: 2023-05-31

using System.Data;
using System.Data.SqlClient;
using System.Text;
using OpenERX.Core.Customers;
using OpenERX.Repositories.Shared.Sql;

namespace OpenERX.Repositories.Customers
{
    public class CustomerImageRepository 
    {
        private readonly SqlConnectionProvider connectionProvider;

        public CustomerImageRepository(SqlConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }

        public async Task<string> InsertByCustomerAsync(Guid customerId, IList<string> urls)
        {
            var commandText = new StringBuilder()
                .AppendLine(" INSERT INTO [tb_customer]")
                .AppendLine(" (")
                .AppendLine(" [id],")
                .AppendLine(" [code],")
                .AppendLine(" [type_code],")
                .AppendLine(" [type_name],")
                .AppendLine(" [name],")
                .AppendLine(" [nickname],")
                .AppendLine(" [display],")
                .AppendLine(" [birth_date],")
                .AppendLine(" [person_type_code],")
                .AppendLine(" [person_type_name],")
                .AppendLine(" [identity],")
                .AppendLine(" [external_code],")
                .AppendLine(" [status_code],")
                .AppendLine(" [status_name],")
                .AppendLine(" [status_date],")
                .AppendLine(" [status_color],")
                .AppendLine(" [status_note],")
                .AppendLine(" [origin_id],")
                .AppendLine(" [origin_code],")
                .AppendLine(" [origin_name],")
                .AppendLine(" [note],")
                .AppendLine(" [account_id],")
                .AppendLine(" [account_code],")
                .AppendLine(" [account_name],")
                .AppendLine(" [store_id],")
                .AppendLine(" [store_code],")
                .AppendLine(" [store_name],")
                .AppendLine(" [broker_id],")
                .AppendLine(" [broker_code],")
                .AppendLine(" [broker_name],")
                .AppendLine(" [creation_date],")
                .AppendLine(" [creation_user_id],")
                .AppendLine(" [creation_user_name],")
                .AppendLine(" [change_date],")
                .AppendLine(" [change_user_id],")
                .AppendLine(" [change_user_name],")
                .AppendLine(" [exclusion_date],")
                .AppendLine(" [exclusion_user_id],")
                .AppendLine(" [exclusion_user_name],")
                .AppendLine(" [record_status_code],")
                .AppendLine(" [record_status_name],")
                .AppendLine(" [version_id],")
                .AppendLine(" [previous_id],")
                .AppendLine(" [version_date]")
                .AppendLine(" )")
                .AppendLine(" VALUES")
                .AppendLine(" (")
                .AppendLine(" @id,")
                .AppendLine(" @code,")
                .AppendLine(" @type_code,")
                .AppendLine(" @type_name,")
                .AppendLine(" @name,")
                .AppendLine(" @nickname,")
                .AppendLine(" @display,")
                .AppendLine(" @birth_date,")
                .AppendLine(" @person_type_code,")
                .AppendLine(" @person_type_name,")
                .AppendLine(" @identity,")
                .AppendLine(" @external_code,")
                .AppendLine(" @status_code,")
                .AppendLine(" @status_name,")
                .AppendLine(" @status_date,")
                .AppendLine(" @status_color,")
                .AppendLine(" @status_note,")
                .AppendLine(" @origin_id,")
                .AppendLine(" @origin_code,")
                .AppendLine(" @origin_name,")
                .AppendLine(" @note,")
                .AppendLine(" @account_id,")
                .AppendLine(" @account_code,")
                .AppendLine(" @account_name,")
                .AppendLine(" @store_id,")
                .AppendLine(" @store_code,")
                .AppendLine(" @store_name,")
                .AppendLine(" @broker_id,")
                .AppendLine(" @broker_code,")
                .AppendLine(" @broker_name,")
                .AppendLine(" @creation_date,")
                .AppendLine(" @creation_user_id,")
                .AppendLine(" @creation_user_name,")
                .AppendLine(" @change_date,")
                .AppendLine(" @change_user_id,")
                .AppendLine(" @change_user_name,")
                .AppendLine(" @exclusion_date,")
                .AppendLine(" @exclusion_user_id,")
                .AppendLine(" @exclusion_user_name,")
                .AppendLine(" @record_status_code,")
                .AppendLine(" @record_status_name,")
                .AppendLine(" @version_id,")
                .AppendLine(" @previous_id,")
                .AppendLine(" @version_date")
                .AppendLine(" )");
            //.AppendLine(" SET @code = SCOPE_IDENTITY(); ");

            await using var cn = await this.connectionProvider.CreateConnectionAsync();
            await using var cm = cn.CreateCommand();

            cm.CommandText = commandText.ToString();

            //var code = cm.Parameters.Add(new SqlParameter("@code", customer.Code) { Direction = ParameterDirection.Output });

            cm.Parameters.Add(new SqlParameter("@id", customer.Id.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@code", customer.Code.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@type_code", customer.TypeCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@type_name", customer.TypeName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@name", customer.Name.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@nickname", customer.Nickname.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@display", customer.Display.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@birth_date", customer.BirthDate.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@person_type_code", customer.PersonTypeCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@person_type_name", customer.PersonTypeName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@identity", customer.Identity.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@external_code", customer.ExternalCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@status_code", customer.StatusCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@status_name", customer.StatusName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@status_date", customer.StatusDate.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@status_color", customer.StatusColor.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@status_note", customer.StatusNote.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@origin_id", customer.OriginId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@origin_code", customer.OriginCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@origin_name", customer.OriginName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@note", customer.Note.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@account_id", customer.AccountId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@account_code", customer.AccountCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@account_name", customer.AccountName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@store_id", customer.StoreId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@store_code", customer.StoreCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@store_name", customer.StoreName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@broker_id", customer.BrokerId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@broker_code", customer.BrokerCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@broker_name", customer.BrokerName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@creation_date", customer.CreationDate.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@creation_user_id", customer.CreationUserId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@creation_user_name", customer.CreationUserName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@change_date", customer.ChangeDate.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@change_user_id", customer.ChangeUserId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@change_user_name", customer.ChangeUserName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@exclusion_date", customer.ExclusionDate.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@exclusion_user_id", customer.ExclusionUserId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@exclusion_user_name", customer.ExclusionUserName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@record_status_code", customer.RecordStatusCode.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@record_status_name", customer.RecordStatusName.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@version_id", customer.VersionId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@previous_id", customer.PreviousId.GetDbValue()));
            cm.Parameters.Add(new SqlParameter("@version_date", customer.VersionDate.GetDbValue()));

            await cm.ExecuteNonQueryAsync();

            //customer.Code = (int)code.Value;

            return customer;
        }
 
        public async Task<long> DeleteByCustomerAsync(Guid customerId)
        {
            var commandText = new StringBuilder()
            .AppendLine(" DELETE FROM [tb_customer]")
            .AppendLine(" WHERE [id] = @id");

            await using var cn = await this.connectionProvider.CreateConnectionAsync();
            await using var cm = cn.CreateCommand();

            cm.CommandText = commandText.ToString();

            cm.Parameters.Add(new SqlParameter("@id", id));

            return await cm.ExecuteNonQueryAsync()  ;
        }
 
        public async Task<IList<string>> GetByCustomerAsync(Guid customerId)
        {
            var commandText = GetFullQuery() 
            .AppendLine(" WHERE [id] = @id");

            await using var cn = await this.connectionProvider.CreateConnectionAsync();
            await using var cm = cn.CreateCommand();

            cm.CommandText = commandText.ToString();
            cm.Parameters.Add(new SqlParameter("@id", id));

            await using var dataReader = await cm.ExecuteReaderAsync();

            while (await dataReader.ReadAsync())
            {
                return GetDataRecord(dataReader);
            }

            return null;
        }

        private static StringBuilder GetFullQuery()
        {
            var commandText = new StringBuilder()
            .AppendLine(" SELECT")
            .AppendLine(" A.[id],")
            .AppendLine(" A.[code],")
            .AppendLine(" A.[type_code],")
            .AppendLine(" A.[type_name],")
            .AppendLine(" A.[name],")
            .AppendLine(" A.[nickname],")
            .AppendLine(" A.[display],")
            .AppendLine(" A.[birth_date],")
            .AppendLine(" A.[person_type_code],")
            .AppendLine(" A.[person_type_name],")
            .AppendLine(" A.[identity],")
            .AppendLine(" A.[external_code],")
            .AppendLine(" A.[status_code],")
            .AppendLine(" A.[status_name],")
            .AppendLine(" A.[status_date],")
            .AppendLine(" A.[status_color],")
            .AppendLine(" A.[status_note],")
            .AppendLine(" A.[origin_id],")
            .AppendLine(" A.[origin_code],")
            .AppendLine(" A.[origin_name],")
            .AppendLine(" A.[note],")
            .AppendLine(" A.[account_id],")
            .AppendLine(" A.[account_code],")
            .AppendLine(" A.[account_name],")
            .AppendLine(" A.[store_id],")
            .AppendLine(" A.[store_code],")
            .AppendLine(" A.[store_name],")
            .AppendLine(" A.[broker_id],")
            .AppendLine(" A.[broker_code],")
            .AppendLine(" A.[broker_name],")
            .AppendLine(" A.[creation_date],")
            .AppendLine(" A.[creation_user_id],")
            .AppendLine(" A.[creation_user_name],")
            .AppendLine(" A.[change_date],")
            .AppendLine(" A.[change_user_id],")
            .AppendLine(" A.[change_user_name],")
            .AppendLine(" A.[exclusion_date],")
            .AppendLine(" A.[exclusion_user_id],")
            .AppendLine(" A.[exclusion_user_name],")
            .AppendLine(" A.[record_status_code],")
            .AppendLine(" A.[record_status_name],")
            .AppendLine(" A.[version_id],")
            .AppendLine(" A.[previous_id],")
            .AppendLine(" A.[version_date]")
            .AppendLine(" FROM [tb_customer] AS A");

            return commandText;
        }

        private static Customer GetDataRecord(SqlDataReader dataRecord)
        {
            var customer = new Customer
            {
                Id = dataRecord.GetGuid("id"),
                Code = dataRecord.GetInt32("code"),
                TypeCode = dataRecord.GetInt32("type_code"),
                TypeName = dataRecord.GetNullableString("type_name"),
                Name = dataRecord.GetString("name"),
                Nickname = dataRecord.GetString("nickname"),
                Display = dataRecord.GetNullableString("display"),
                BirthDate = dataRecord.GetNullableDateTime("birth_date"),
                PersonTypeCode = dataRecord.GetInt32("person_type_code"),
                PersonTypeName = dataRecord.GetNullableString("person_type_name"),
                Identity = dataRecord.GetString("identity"),
                ExternalCode = dataRecord.GetNullableString("external_code"),
                StatusCode = dataRecord.GetInt32("status_code"),
                StatusName = dataRecord.GetNullableString("status_name"),
                StatusDate = dataRecord.GetNullableDateTime("status_date"),
                StatusColor = dataRecord.GetNullableString("status_color"),
                StatusNote = dataRecord.GetNullableString("status_note"),
                OriginId = dataRecord.GetGuid("origin_id"),
                OriginCode = dataRecord.GetInt32("origin_code"),
                OriginName = dataRecord.GetNullableString("origin_name"),
                Note = dataRecord.GetNullableString("note"),
                AccountId = dataRecord.GetGuid("account_id"),
                AccountCode = dataRecord.GetInt32("account_code"),
                AccountName = dataRecord.GetString("account_name"),
                StoreId = dataRecord.GetGuid("store_id"),
                StoreCode = dataRecord.GetInt32("store_code"),
                StoreName = dataRecord.GetNullableString("store_name"),
                BrokerId = dataRecord.GetGuid("broker_id"),
                BrokerCode = dataRecord.GetInt32("broker_code"),
                BrokerName = dataRecord.GetNullableString("broker_name"),
                CreationDate = dataRecord.GetDateTime("creation_date"),
                CreationUserId = dataRecord.GetGuid("creation_user_id"),
                CreationUserName = dataRecord.GetString("creation_user_name"),
                ChangeDate = dataRecord.GetNullableDateTime("change_date"),
                ChangeUserId = dataRecord.GetGuid("change_user_id"),
                ChangeUserName = dataRecord.GetNullableString("change_user_name"),
                ExclusionDate = dataRecord.GetNullableDateTime("exclusion_date"),
                ExclusionUserId = dataRecord.GetGuid("exclusion_user_id"),
                ExclusionUserName = dataRecord.GetNullableString("exclusion_user_name"),
                RecordStatusCode = dataRecord.GetInt32("record_status_code"),
                RecordStatusName = dataRecord.GetString("record_status_name"),
                VersionId = dataRecord.GetGuid("version_id"),
                PreviousId = dataRecord.GetGuid("previous_id"),
                VersionDate = dataRecord.GetDateTime("version_date")
            };

            return customer;
        }
    }
}
