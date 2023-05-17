// COMPANY: Ajinsoft
// AUTHOR: Uilan Coqueiro
// DATE: 2023-05-17

using OpenERX.Commons.Types.Generics;

namespace OpenERX.Core.Customers
{
    public class CustomerType : CodeName
    {
        public static CustomerType Type1 = new(1, "Type1");
        public static CustomerType Type2 = new(2, "Type2");

        public CustomerType(short code, string name) : base(code, name) { }
        public static IEnumerable<CustomerType> GetAll() => GetAll<CustomerType>();
        public static CustomerType Get(short code) => Get<CustomerType>(code);
    }
}
