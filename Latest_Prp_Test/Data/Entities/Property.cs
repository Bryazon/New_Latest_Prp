using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities.Base_Types;
using WebApplication7.Data.Entities.Complex_Types;
using WebApplication7.Data.Entities.EnumTypes;

namespace WebApplication7.Data.Entities
{
    public class Property : OrganisationEntity
    {
        public ICollection<PropertyContact> VendorLinks { get; set; }
        public ICollection<PropertyImage> Images { get; set; } 
        public int Id { get; set; } 
        public decimal Price { get; set; }

        #region Complex Types
        public Address Address { get; set; }
        public PropertyStatus Status { get; set; } 
        #endregion

    }
}
