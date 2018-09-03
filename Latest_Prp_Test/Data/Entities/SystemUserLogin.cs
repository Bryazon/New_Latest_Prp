using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Data.Entities
{
    public class SystemUserLogin : IdentityUser
    {
        public SystemUser User { get; set; }
    }
}
