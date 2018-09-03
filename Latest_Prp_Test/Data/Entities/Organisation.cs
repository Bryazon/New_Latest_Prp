using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.Entities.Base_Types;
using WebApplication7.Data.Entities.Complex_Types;

namespace WebApplication7.Data.Entities
{
    public class Organisation : TimeStampedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region Complex Types
        public ICollection<Team> Teams { get; set; }
        public ICollection<SystemUser> Users { get; set; }
        public Address Address { get; set; }
        #endregion
    }
}
