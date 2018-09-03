using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Data.Entities.EnumTypes
{
    public class PropertyStatus : SmartEnum<PropertyStatus, string>
    {
        public static PropertyStatus ForSale = new PropertyStatus("For Sale", "FSA"); 
        public static PropertyStatus Withdrawn = new PropertyStatus("Withdrawn", "WDN");

        protected PropertyStatus(string name, string value) : base(name, value)
        {

        }
    }
}
