using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Authorisation;
using WebApplication7.Data.Entities.Base_Types;
using WebApplication7.Data.Entities.Complex_Types;

namespace WebApplication7.Data.Entities
{
    public class SystemUser : OrganisationEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        #region Complex Types
        public ICollection<SystemUserImage> UserImages { get; set; }
        public ICollection<TeamMembership> TeamMembership { get; set; }
        public Address Address { get; set; }
        #endregion

        public SystemUser()
        { 

        }
    }
}
