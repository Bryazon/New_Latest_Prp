using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Services.Formatting;

namespace WebApplication7.ViewModels
{
    public class AddressViewModel
    {
        public string HouseName { get; set; }
        public string HouseNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress
        {
            get
            {
                return AddressFormattingService.FormatAddress(HouseName, HouseNumber, Address1, Address2, Address3, Address4, PostalCode);
            }
        }
    }
}
