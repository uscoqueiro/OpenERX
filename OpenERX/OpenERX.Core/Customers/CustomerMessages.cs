// COMPANY: Ajinsoft
// AUTHOR: Uilan Coqueiro
// DATE: 2023-05-17


using OpenERX.Commons.Results;

namespace OpenERX.Core.Customers
{
    public class CustomerMessages
    {
        public static ResultMessage NotFound = new(ResultMessageTypes.Error, "Cliente não encontrado", "1002001");
    }
}
