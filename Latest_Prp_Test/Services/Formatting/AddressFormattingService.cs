using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities;

namespace WebApplication7.Services.Formatting
{
    public static class AddressFormattingService
    {
        public static string FormatAddress(string houseName, string houseNumber, string address1, string address2, string address3, string address4, string postalCode)
        {
            return (houseName + ", " + houseNumber + " " + address1 + ", " + address2 + ", " + address3 + ", " + address4).Replace(" ,", "").Trim(", ".ToCharArray());

        }
    }
}
