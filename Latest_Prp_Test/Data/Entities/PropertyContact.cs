using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities.Base_Types;

namespace WebApplication7.Data.Entities
{
    public class PropertyContact : TimeStampedEntity
    {
        public int Id { get; set; }
        public bool IsMain { get; set; }
        public Contact Contact { get; set; }
        public Property Property { get; set; }
    }
}
