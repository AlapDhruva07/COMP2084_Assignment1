using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP2084_Assignment1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace COMP2084_Assignment1
{
    public class Context : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<COMP2084_Assignment1.Models.Car> Car { get; set; }

        public DbSet<COMP2084_Assignment1.Models.Company> Company { get; set; }
    }
}
