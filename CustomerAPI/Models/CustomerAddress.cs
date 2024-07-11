using System.ComponentModel.DataAnnotations;

namespace CustomerAPI.Models
{
    public class CustomerAddress
    {
        [Key]
        public int CustomerAddressID { get; set; }

        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string AddressType { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
