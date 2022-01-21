using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace leaveManagement.Data.Migrations
{

    public class Employee : IdentityUser
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Taxid { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }
    }
}
