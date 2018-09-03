using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities.Base_Types;
using WebApplication7.Data.Entities.Complex_Types;

namespace WebApplication7.Data.Entities
{
    public class Contact : OrganisationEntity
    {
        public ICollection<PropertyContact> VendorRoles { get; set; } 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
         
        #region Complex Types
        public Address Address { get; set; }
        #endregion

 
    }
}
