using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities.Base_Types;

namespace WebApplication7.Data.Entities
{
    public class TeamMembership : OrganisationEntity
    {
        public int Id { get; set; }
        public bool IsMain { get; set; }
        public Team Team { get; set; }
        public SystemUser User { get; set; }
    }
}
