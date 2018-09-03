using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Data.Entities.Base_Types
{
    public class TimeStampedEntity
    {
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
