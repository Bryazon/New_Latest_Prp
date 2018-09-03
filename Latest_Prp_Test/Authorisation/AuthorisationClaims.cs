using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Authorisation
{
    public class CustomClaimTypes
    {
        public const string Permission = "cbtest/permission";
    }

    public class AuthorisationClaims
    {
        public class TeamClaims : SmartEnum<TeamClaims, string>
        {
            public static TeamClaims ApproveNewUsers = new TeamClaims("Can approve new users", "team.users.add");

            protected TeamClaims(string name, string value) : base(name, value)
            {

            }
        }
    }
}
