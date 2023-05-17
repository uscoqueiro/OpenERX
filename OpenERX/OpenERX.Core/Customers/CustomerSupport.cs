// COMPANY: Ajinsoft
// AUTHOR: Uilan Coqueiro
// DATE: 2023-05-17

namespace OpenERX.Core.Customers
{
public class CustomerSupport
{
public IEnumerable<CustomerStatus> Status => CustomerStatus.GetAll();
public IEnumerable<CustomerType> Types => CustomerType.GetAll();
}
}
